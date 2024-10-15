using System.Text.Json.Serialization;
using LevelZHelper.Models.LevelConfigs;

namespace LevelZHelper.Models.ConfigFiles
{
    internal class BlockConfigFile
    {
        public BlockConfigFile() { }

        public BlockConfigFile(BlockLevelConfig levelConfig)
        {
            Replace = false;
            Skill = levelConfig.Skill.ToString().ToLower();
            Level = levelConfig.Level;
            Block = "minecraft:custom_block";
            Object = $"{levelConfig.ModId}:{levelConfig.Name}";
        }

        [JsonPropertyName("replace")]
        public bool? Replace { get; set; }

        [JsonPropertyName("skill")]
        public string? Skill { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("block")]
        public string? Block { get; set; }

        [JsonPropertyName("object")]
        public string? Object { get; set; }
    }
}