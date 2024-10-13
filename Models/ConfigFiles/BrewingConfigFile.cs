﻿using System.Text.Json.Serialization;
using LevelZHelper.Models.LevelConfigs;

namespace LevelZHelper.Models.ConfigFiles
{
    internal class BrewingConfigFile
    {
        public BrewingConfigFile() { }

        public BrewingConfigFile(IEnumerable<BrewingLevelConfig> levelConfig)
        {
            Replace = true;
            Level = levelConfig.First().Level;
            Items = levelConfig.Select(config => $"{config.ModId}:{config.Name}").ToList();
        }

        [JsonPropertyName("replace")]
        public bool? Replace { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("item")]
        public List<string> Items { get; set; } = [];
    }
}