using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Models.Templating.TemplateItems
{
    internal class MaterialToolTemplateItem : ITemplateItem
    {
        private readonly string _baseName;
        private readonly Skills _skill;

        private string _material = string.Empty;

        public MaterialToolTemplateItem(string baseName, Skills skill)
        {
            _baseName = baseName;
            _skill = skill;
        }

        public ILevelConfig ToLevelConfig(ITemplate template)
        {
            var item = new MaterialItemLevelConfig()
            {
                ModId = template.ModKey,
                Name = _baseName,
                Material = _material
            };

            item.TrySetSkill(_skill);
            item.TrySetLevel(template.Level);

            return item;
        }

        internal void Update(string? material)
        {
            _material = material ?? string.Empty;
        }

        public override string ToString()
        {
            var fullName = $"{_material}_{_baseName}";
            var name = fullName.Length > 47 ? $"{fullName[..44]}..." : fullName;

            return $"[MI] {name,-47}";
        }
    }
}
