using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;
using LevelZHelper.Models.Templating.TemplateItems;

namespace LevelZHelper.Models.Templating
{
    internal class MaterialToolTemplate : ITemplate
    {
        private List<ITemplateItem> TemplateItems { get; set; } = new();

        private string? _material;

        public string ModKey 
        { 
            get { return "minecraft"; }
            set { return; }
        }

        public string BaseName
        {
            get { return string.Empty; }
            set { return; }
        }

        public Skills Skill { get; set; }

        public int Level { get; set; }

        public string? Material 
        {
            get { return _material ?? string.Empty; }
            set
            {
                _material = value;
                UpdateTemplateItems();
            }
        }

        public EditFields EnabledFields
            => EditFields.Level | EditFields.Material;

        public TemplateType TypeValue
            => TemplateType.MaterialToolSet;

        public void Configure()
        {
            TemplateItems.Add(new MaterialToolTemplateItem("sword", Skills.Strength)) ;
            TemplateItems.Add(new MaterialToolTemplateItem("axe", Skills.Farming));
            TemplateItems.Add(new MaterialToolTemplateItem("tool", Skills.Mining));
            TemplateItems.Add(new MaterialToolTemplateItem("hoe", Skills.Farming));
        }

        public List<ILevelConfig> GetLevelConfigs()
        {
            return TemplateItems.Select(i => i.ToLevelConfig(this)).ToList();
        }

        private void UpdateTemplateItems()
        {
            foreach (var item in TemplateItems)
            {
                if (item is MaterialToolTemplateItem armorItem) armorItem.Update(Material);
            }
        }

        public override string ToString()
        {
            var itemStrings = TemplateItems.Select(i => i.ToString());

            return string.Join("\r\n", itemStrings);
        }
    }
}
