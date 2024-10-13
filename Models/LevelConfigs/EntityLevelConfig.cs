using LevelZHelper.Models.ConfigFiles;
using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Models.LevelConfigs
{
    internal class EntityLevelConfig : ILevelConfig
    {
        public EntityLevelConfig()
        {
            Name = "new entity object";
        }

        public EntityLevelConfig(EntityConfigFile fileData)
        {
            var splitName = fileData.Entity?.Split(':');

            ModId = splitName?.FirstOrDefault() ?? string.Empty;
            Name = splitName?.LastOrDefault() ?? string.Empty;
            Skill = fileData.Skill?.ToSkills() ?? Skills.None;
            Level = fileData.Level != null ? Math.Clamp(fileData.Level.Value, 1, 20) : 1;
        }

        public string? ModId { get; set; }

        public string Name { get; set; }

        public Skills Skill { get; private set; }

        public int Level { get; private set; } = 1;

        public string? Material { get; set; }

        public string TypeString => "Entity";

        public ConfigType ConfigType => ConfigType.Entity;

        public EditFields AllowedFields
           => EditFields.ModKey | EditFields.Name | EditFields.Level | EditFields.Skill;

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
            var fullName = $"{ModId}:{Name}";
            var name = fullName.Length > 47 ? $"{fullName[..44]}..." : fullName;

            return $"[E] {name,-47} - {Skill,-8} {Level,2}";
        }
    }
}
