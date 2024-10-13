using System.Text.Json.Serialization;
using LevelZHelper.Models.LevelConfigs;

namespace LevelZHelper.Models.ConfigFiles
{
    internal class MiningConfigFile
    {
        public MiningConfigFile() { }

        public MiningConfigFile(IEnumerable<MiningLevelConfig> levelConfig)
        {
            Replace = true;
            Level = levelConfig.First().Level;
            Blocks = levelConfig.Select(config => $"{config.ModId}:{config.Name}").ToList();
        }

        [JsonPropertyName("replace")]
        public bool? Replace { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("block")]
        public List<string> Blocks { get; set; } = [];
    }
}