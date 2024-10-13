using System.Text.Json.Serialization;
using LevelZHelper.Models.LevelConfigs;

namespace LevelZHelper.Models.ConfigFiles
{
    internal class ItemConfigFile
    {
        public ItemConfigFile() { }

        public ItemConfigFile(ItemLevelConfig levelConfig)
        {
            Replace = true;
            Skill = levelConfig.Skill.ToString().ToLower();
            Level = levelConfig.Level;
            Item = "minecraft:custom_item";
            Object = $"{levelConfig.ModId}:{levelConfig.Name}";
        }

        public ItemConfigFile(MaterialItemLevelConfig levelConfig)
        {
            Replace = true;
            Skill = levelConfig.Skill.ToString().ToLower();
            Level = levelConfig.Level;
            Item = $"{levelConfig.ModId}:{levelConfig.Name}";
            Material = levelConfig.Material;
        }

        [JsonPropertyName("replace")]
        public bool? Replace { get; set; }

        [JsonPropertyName("skill")]
        public string? Skill { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("item")]
        public string? Item { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }

        [JsonPropertyName("material")]
        public string? Material { get; set; }
    }
}