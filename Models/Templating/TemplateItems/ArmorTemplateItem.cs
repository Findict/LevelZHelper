using LevelZHelper.Models.LevelConfigs;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Models.Templating.TemplateItems
{
    internal class ArmorTemplateItem : ITemplateItem
    {
        private readonly string _format;
        private string _modKey = string.Empty;
        private string _baseName = string.Empty;

        public ArmorTemplateItem(string format)
        {
            _format = format;
        }

        public void Update(string modKey, string baseName)
        {
            _modKey = modKey;
            _baseName = baseName;
        }

        public ILevelConfig ToLevelConfig(ITemplate template)
        {
            var item = new ItemLevelConfig()
            {
                ModId = _modKey,
                Name = string.Format(_format, _baseName),
            };

            item.TrySetSkill(template.Skill);
            item.TrySetLevel(template.Level);

            return item;
        }

        public override string ToString()
        {
            var fullName = $"{_modKey}:{string.Format(_format, _baseName)}";
            var name = fullName.Length > 47 ? $"{fullName[..44]}..." : fullName;

            return $"[I] {name,-47}";
        }
    }
}