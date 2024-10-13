using LevelZHelper.Models.ConfigFiles;
using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Models.LevelConfigs
{
    internal class MaterialItemLevelConfig : ILevelConfig
    {
        public MaterialItemLevelConfig()
        {
            Name = "item";
            Material = "new_material";
        }

        public MaterialItemLevelConfig(ItemConfigFile fileData)
        {
            var itemName = !string.IsNullOrEmpty(fileData.Object) ? fileData.Object : fileData.Item;
            var splitName = itemName?.Split(':');

            ModId = splitName?.FirstOrDefault() ?? string.Empty;
            Name = splitName?.LastOrDefault() ?? string.Empty;

            Skill = fileData.Skill?.ToSkills() ?? Skills.None;
            Level = fileData.Level != null ? Math.Clamp(fileData.Level.Value, 1, 20) : 1;
            Material = fileData.Material ?? string.Empty;
        }

        public string? ModId { get; set; }

        public string Name { get; set; }

        public Skills Skill { get; private set; }

        public int Level { get; private set; } = 1;

        public string? Material { get; set; }

        public string TypeString => "Item";

        public ConfigType ConfigType => ConfigType.MaterialItem;

        public EditFields AllowedFields
           => EditFields.ModKey | EditFields.Name | EditFields.Level | EditFields.Skill | EditFields.Material | EditFields.ToSmithing;

        public Skills TrySetSkill(Skills value)
        {
            Skill = value;

            return Skill;
        }

        public int TrySetLevel(decimal value)
        {
            Level = (int)value;
            return Level;
        }

        public override string ToString()
        {
            var fullName = $"{ModId}:{Material}_{Name}";
            var name = fullName.Length > 46 ? $"{fullName[..43]}..." : fullName;

            return $"[MI] {name,-46} - {Skill,-8} {Level,2}";
        }
    }
}
