using LevelZHelper.Models.Enums;

namespace LevelZHelper.Models.LevelConfigs.Interfaces
{
    internal interface ILevelConfig
    {
        string? ModId { get; set; }

        string Name { get; set; }

        Skills Skill { get; }

        int Level { get; }

        string? Material { get; set; }

        string TypeString { get; }

        ConfigType ConfigType { get; }

        EditFields AllowedFields { get; }

        Skills TrySetSkill(Skills value);

        int TrySetLevel(decimal value);
    }
}