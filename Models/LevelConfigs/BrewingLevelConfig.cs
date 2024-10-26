using LevelZHelper.Models.ConfigFiles;
using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Models.LevelConfigs
{
    internal class BrewingLevelConfig : ILevelConfig
    {
        public BrewingLevelConfig()
        {
            Name = "new brewing object";
            Skill = Skills.Alchemy;
        }

        public BrewingLevelConfig(string item, BrewingConfigFile fileData)
        {
            var splitName = item.Split(':');

            ModId = splitName.FirstOrDefault() ?? string.Empty;
            Name = splitName.LastOrDefault() ?? string.Empty;
            Skill = Skills.Alchemy;
            Level = fileData.Level != null ? Math.Clamp(fileData.Level.Value, 1, 20) : 1;
            Replace = fileData.Replace ?? false;
        }

        public string? ModId { get; set; }

        public string Name { get; set; }

        public Skills Skill { get; private set; }

        public int Level { get; private set; } = 1;

        public string? Material { get; set; }

        public bool Replace { get; set; }

        public string TypeString => "Brewing";

        public ConfigType ConfigType => ConfigType.Brewing;

        public EditFields AllowedFields
           => EditFields.ModKey | EditFields.Name | EditFields.Level;

        public Skills TrySetSkill(Skills _)
        {
            return Skill;
        }

        public int TrySetLevel(decimal value)
        {
            Level = (int)value;
            return Level;
        }

        public override string ToString()
        {
            var fullName = $"{ModId}:{Name}";
            var name = fullName.Length > 47 ? $"{fullName[..44]}..." : fullName;

            return $"[R] {name,-47} {(Replace ? '=' : '-')} {Skill,-8} {Level,2}";
        }
    }
}
