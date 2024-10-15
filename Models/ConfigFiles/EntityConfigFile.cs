using System.Text.Json.Serialization;
using LevelZHelper.Models.LevelConfigs;

namespace LevelZHelper.Models.ConfigFiles
{
    internal class EntityConfigFile
    {
        public EntityConfigFile() { }

        public EntityConfigFile(EntityLevelConfig levelConfig)
        {
            Replace = false;
            Skill = levelConfig.Skill.ToString().ToLower();
            Level = levelConfig.Level;
            Entity = $"{levelConfig.ModId}:{levelConfig.Name}";
        }

        [JsonPropertyName("replace")]
        public bool? Replace { get; set; }

        [JsonPropertyName("skill")]
        public string? Skill { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("entity")]
        public string? Entity { get; set; }
    }
}