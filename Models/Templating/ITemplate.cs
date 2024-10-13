using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;
using LevelZHelper.Views;

namespace LevelZHelper.Models.Templating
{
    internal interface ITemplate
    {
        string ModKey { get; set; }

        string BaseName { get; set; }

        Skills Skill { get; set; }

        int Level { get; set; }

        string? Material { get; set; }

        EditFields EnabledFields { get; }

        TemplateType TypeValue { get; }

        void Configure();

        List<ILevelConfig> GetLevelConfigs();
    }
}