using System.IO.Compression;
using System.Text.Json;
using System.Text.Json.Serialization;
using LevelZHelper.Models;
using LevelZHelper.Models.AuxFiles;
using LevelZHelper.Models.ConfigFiles;
using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs;
using LevelZHelper.Models.LevelConfigs.Interfaces;
using LevelZHelper.Models.Templating;
using Microsoft.VisualBasic.FileIO;

namespace LevelZHelper.Managers
{
    internal class LevelConfigManager
    {
        private readonly List<ILevelConfig> _configs = new();

        private readonly JsonSerializerOptions _convertOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        internal AddOnMetadata Metadata { get; set; } = new();

        internal ILevelConfig? AddItem(ConfigType configType)
        {
            ILevelConfig newItem;

            switch (configType)
            {
                case ConfigType.Item:
                    newItem = new ItemLevelConfig();
                    break;
                case ConfigType.MaterialItem:
                    newItem = new MaterialItemLevelConfig();
                    break;
                case ConfigType.Block:
                    newItem = new BlockLevelConfig();
                    break;
                case ConfigType.Mining:
                    newItem = new MiningLevelConfig();
                    break;
                case ConfigType.Smithing:
                    newItem = new SmithingLevelConfig();
                    break;
                case ConfigType.Entity:
                    newItem = new EntityLevelConfig();
                    break;
                case ConfigType.Brewing:
                    newItem = new BrewingLevelConfig();
                    break;
                default:
                    return null;
            }

            _configs.Add(newItem);

            return newItem;
        }

        internal List<ILevelConfig> GetConfigs()
            => _configs;

        internal bool DeleteItem(ILevelConfig item) 
            => _configs.Remove(item);

        internal void ClearAll()
        {
            _configs.Clear();
            Metadata.Clear();
        }

        internal void ImportAll(string selectedFile)
        {
            var tempPath = $"{Path.GetTempPath()}\\levelz-import";

            if (Directory.Exists(tempPath))
            {
                foreach (var item in Directory.GetDirectories(tempPath))
                {
                    FileSystem.DeleteDirectory(item, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                }

                foreach (var item in Directory.GetFiles(tempPath))
                {
                    FileSystem.DeleteFile(item, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                }
            }
            else
            {
                Directory.CreateDirectory(tempPath);
            }

            ZipFile.ExtractToDirectory(selectedFile, tempPath);

            ImportMetaData($"{tempPath}\\fabric.mod.json");
            ImportIcon($"{tempPath}\\icon.png");

            var configsPath = $"{tempPath}\\data\\levelz";

            if (!Directory.Exists(configsPath)) return;

            var directories = Directory.GetDirectories(configsPath);

            if (directories == null || directories.Length == 0) return;

            foreach (var directory in directories)
            {
                var subFolder = directory.Split('\\','/').Last();

                switch (subFolder)
                {
                    case "item":
                        ImportItems(directory);
                        break;
                    case "block":
                        ImportBlocks(directory);
                        break;
                    case "mining":
                        ImportMining(directory);
                        break;
                    case "smithing":
                        ImportSmithing(directory);
                        break;
                    case "brewing":
                        ImportBrewing(directory);
                        break;
                    case "entity":
                        ImportEntity(directory);
                        break;
                    default:
                        break;
                }
            }
        }

        internal void ExportAll(SaveFileDialog dialog)
        {
            var tempPath = $"{Path.GetTempPath()}\\levelz-export";

            var configsPath = $"{tempPath}\\data\\levelz";

            if (Directory.Exists(tempPath))
            {
                foreach (var item in Directory.GetDirectories(tempPath))
                {
                    FileSystem.DeleteDirectory(item, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                }

                foreach (var item in Directory.GetFiles(tempPath))
                {
                    FileSystem.DeleteFile(item, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                }
            }
            else
            {
                Directory.CreateDirectory(tempPath);
            }

            ExportMetaData($"{tempPath}\\");
            ExportIcon($"{tempPath}\\");

            ExportItems($"{configsPath}\\item\\");
            ExportMaterialItems($"{configsPath}\\item\\");
            ExportEntities($"{configsPath}\\entity\\");
            ExportBlocks($"{configsPath}\\block\\");
            ExportMining($"{configsPath}\\mining\\");
            ExportSmithing($"{configsPath}\\smithing\\");
            ExportBrewing($"{configsPath}\\brewing\\");

            CreateJar(tempPath, dialog);
        }

        internal void AppendItems(IEnumerable<ILevelConfig>? items)
        {
            if (items == null) return;

            _configs.AddRange(items);
        }

        internal void AddItemsFromTemplate(ITemplate template)
        {
            var newItems = template.GetLevelConfigs();

            AppendItems(newItems);
        }

        #region Import functions

        internal void ImportIcon(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var iconFile = File.OpenRead(filePath);

            Metadata.SetIcon(Image.FromStream(iconFile));

            iconFile.Close();
        }

        private void ImportMetaData(string filePath)
        {
            if (!File.Exists(filePath)) return;

            using var file = File.OpenRead(filePath);
            var fileData = JsonSerializer.Deserialize<FabricModFile>(file);

            if (fileData == null) return;

            Metadata.Update(fileData);
        }

        private void ImportItems(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var filePath in files)
            {
                using var file = File.OpenRead(filePath);
                var fileData = JsonSerializer.Deserialize<ItemConfigFile>(file);

                if (fileData == null) continue;

                if (!string.IsNullOrWhiteSpace(fileData.Material))
                {
                    _configs.Add(new MaterialItemLevelConfig(fileData));
                }
                else
                {
                    _configs.Add(new ItemLevelConfig(fileData));
                }
            }
        }

        private void ImportEntity(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var filePath in files)
            {
                using var file = File.OpenRead(filePath);
                var fileData = JsonSerializer.Deserialize<EntityConfigFile>(file);

                if (fileData == null) continue;

                var newItem = new EntityLevelConfig(fileData);

                _configs.Add(newItem);
            }
        }

        private void ImportBlocks(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var filePath in files)
            {
                using var file = File.OpenRead(filePath);
                var fileData = JsonSerializer.Deserialize<BlockConfigFile>(file);

                if (fileData == null) continue;

                var newItem = new BlockLevelConfig(fileData);

                _configs.Add(newItem);
            }
        }

        private void ImportMining(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var filePath in files)
            {
                using var file = File.OpenRead(filePath);
                var fileData = JsonSerializer.Deserialize<MiningConfigFile>(file);

                if (fileData == null || fileData.Blocks.Count == 0) continue;

                foreach (var item in fileData.Blocks)
                {
                    var newItem = new MiningLevelConfig(item, fileData);
                    _configs.Add(newItem);
                }
            }
        }

        private void ImportSmithing(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var filePath in files)
            {
                using var file = File.OpenRead(filePath);
                var fileData = JsonSerializer.Deserialize<SmithingConfigFile>(file);

                if (fileData == null || fileData.Items.Count == 0) continue;

                foreach (var item in fileData.Items)
                {
                    var newItem = new SmithingLevelConfig(item, fileData);
                    _configs.Add(newItem);
                }
            }
        }

        private void ImportBrewing(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var filePath in files)
            {
                using var file = File.OpenRead(filePath);
                var fileData = JsonSerializer.Deserialize<BrewingConfigFile>(file);

                if (fileData == null || fileData.Items.Count == 0) continue;

                foreach (var item in fileData.Items)
                {
                    var newItem = new BrewingLevelConfig(item, fileData);
                    _configs.Add(newItem);
                }
            }
        }

        #endregion

        #region Export functions

        private void CreateJar(string source, SaveFileDialog dialog)
        {
            try
            {
                var jarFile = dialog.OpenFile();

                ZipFile.CreateFromDirectory(source, jarFile);

                jarFile.Flush();
                jarFile.Close();
            }
            catch (IOException e)
            {
                // _logger.ShowWarning(e);
            }
        }

        private void ExportIcon(string selectedPath)
        {
            if (Metadata.Icon == null) return;

            Metadata.Icon.Save($"{selectedPath}icon.png");
        }

        private void ExportMetaData(string selectedPath)
        {
            if (Metadata == null) return;

            WriteFile(selectedPath, "fabric.mod", new FabricModFile(Metadata));
            WriteFile(selectedPath, "pack", new PackMetaFile(Metadata), "mcmeta");
            WriteFile(selectedPath, "quilt.mod", new QuiltModFile(Metadata));
        }

        private void ExportItems(string selectedPath)
        {
            var items = _configs.Where(c => c is ItemLevelConfig config && config != null).Select(c => (ItemLevelConfig)c).ToList();
            
            if (items.Count == 0) return;

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var item in items)
            {
                var configFileItem = new ItemConfigFile(item);

                WriteFile(selectedPath, item.Name, configFileItem);
            }
        }

        private void ExportMaterialItems(string selectedPath)
        {
            var items = _configs.Where(c => c is MaterialItemLevelConfig config && config != null).Select(c => (MaterialItemLevelConfig)c).ToList();

            if (items.Count == 0) return;

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var item in items)
            {
                var configFileItem = new ItemConfigFile(item);

                WriteFile(selectedPath, $"{item.Material}_{item.Name}", configFileItem);
            }
        }

        private void ExportEntities(string selectedPath)
        {
            var items = _configs.Where(c => c is EntityLevelConfig config && config != null).Select(c => (EntityLevelConfig)c).ToList();

            if (items.Count == 0) return;

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var item in items)
            {
                var configFileItem = new EntityConfigFile(item);

                WriteFile(selectedPath, item.Name, configFileItem);
            }
        }

        private void ExportBlocks(string selectedPath)
        {
            var items = _configs.Where(c => c is BlockLevelConfig config && config != null).Select(c => (BlockLevelConfig)c).ToList();

            if (items.Count == 0) return;

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var item in items)
            {
                var configFileItem = new BlockConfigFile(item);

                WriteFile(selectedPath, item.Name, configFileItem);
            }
        }

        private void ExportMining(string selectedPath)
        {
            var items = _configs.Where(c => c is MiningLevelConfig config && config != null).Select(c => (MiningLevelConfig)c).ToList();

            if (items.Count == 0) return;

            var itemLevels = items.Select(i => i.Level).Distinct();

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var itemLevel in itemLevels)
            {
                var levelItems = items.Where(i => i.Level == itemLevel).ToList();

                var configFileItem = new MiningConfigFile(items.Where(i => i.Level == itemLevel).ToList());

                WriteFile(selectedPath, $"{levelItems.First().ModId}_level_{itemLevel}", configFileItem);
            }
        }

        private void ExportSmithing(string selectedPath)
        {
            var items = _configs.Where(c => c is SmithingLevelConfig config && config != null).Select(c => (SmithingLevelConfig)c).ToList();

            if (items.Count == 0) return;

            var itemLevels = items.Select(i => i.Level).Distinct();

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var itemLevel in itemLevels)
            {
                var levelItems = items.Where(i => i.Level == itemLevel).ToList();

                var configFileItem = new SmithingConfigFile(items.Where(i => i.Level == itemLevel).ToList());

                WriteFile(selectedPath, $"{levelItems.First().ModId}_level_{itemLevel}", configFileItem);
            }
        }

        private void ExportBrewing(string selectedPath)
        {
            var items = _configs.Where(c => c is BrewingLevelConfig config && config != null).Select(c => (BrewingLevelConfig)c).ToList();

            if (items.Count == 0) return;

            var itemLevels = items.Select(i => i.Level).Distinct();

            if (!Directory.Exists(selectedPath))
            {
                Directory.CreateDirectory(selectedPath);
            }

            foreach (var itemLevel in itemLevels)
            {
                var levelItems = items.Where(i => i.Level == itemLevel).ToList();

                var configFileItem = new BrewingConfigFile(items.Where(i => i.Level == itemLevel).ToList());

                WriteFile(selectedPath, $"{levelItems.First().ModId}_level_{itemLevel}", configFileItem);
            }
        }

        #endregion

        private void WriteFile(string selectedPath, string fileName, object configFileItem, string extension = "json")
        {
            using var fileStream = File.Create($"{selectedPath}{fileName}.{extension}");

            JsonSerializer.Serialize(fileStream, configFileItem, _convertOptions);

            fileStream.Close();
        }
    }
}
