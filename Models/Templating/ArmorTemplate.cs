using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;
using LevelZHelper.Models.Templating.TemplateItems;
using LevelZHelper.Views;

namespace LevelZHelper.Models.Templating
{
    internal class ArmorTemplate : ITemplate
    {
        private List<ITemplateItem> TemplateItems { get; set; } = new();

        private string _modKey = string.Empty;
        private string _baseName = string.Empty;

        public string ModKey
        {
            get { return _modKey; }
            set
            {
                _modKey = value;
                UpdateTemplateItems();
            }
        }

        public string BaseName 
        {
            get { return _baseName; }
            set 
            {
                _baseName = value;
                UpdateTemplateItems();
            }
        }

        public Skills Skill { get; set; }

        public int Level { get; set; } = 1;

        public string? Material
        {
            get { return null; }
            set { return; }
        }

        public EditFields EnabledFields
            => EditFields.ModKey | EditFields.Name | EditFields.Level | EditFields.Skill;

        public TemplateType TypeValue
            => TemplateType.Armor;

        public void Configure()
        {
            TemplateItems.Add(new ArmorTemplateItem("{0}_head"));
            TemplateItems.Add(new ArmorTemplateItem("{0}_chest"));
            TemplateItems.Add(new ArmorTemplateItem("{0}_legs"));
            TemplateItems.Add(new ArmorTemplateItem("{0}_feet"));

            TemplateItems.Add(new SmithingTemplateItem("{0}_head"));
            TemplateItems.Add(new SmithingTemplateItem("{0}_chest"));
            TemplateItems.Add(new SmithingTemplateItem("{0}_legs"));
            TemplateItems.Add(new SmithingTemplateItem("{0}_feet"));
        }

        public List<ILevelConfig> GetLevelConfigs()
        {
            return TemplateItems.Select(i => i.ToLevelConfig(this)).ToList();
        }

        private void UpdateTemplateItems()
        {
            foreach (var item in TemplateItems)
            {
                if (item is ArmorTemplateItem armorItem) armorItem.Update(ModKey, BaseName);
                if (item is SmithingTemplateItem smithingItem) smithingItem.Update(ModKey, BaseName);
            }
        }

        public override string ToString()
        {
            var itemStrings = TemplateItems.Select(i => i.ToString());

            return string.Join("\r\n", itemStrings);
        }
    }
}
