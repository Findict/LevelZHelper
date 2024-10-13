using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Models.Templating.TemplateItems
{
    internal interface ITemplateItem
    {
        ILevelConfig ToLevelConfig(ITemplate template);
    }
}