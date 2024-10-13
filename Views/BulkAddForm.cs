using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Views
{
    public partial class BulkAddForm : Form
    {
        public BulkAddForm()
        {
            InitializeComponent();
        }

        private void BulkAddForm_Load(object sender, EventArgs e)
        {
            SkillsComboBox.DataSource = Enum.GetValues(typeof(Skills));
        }

        internal delegate void SubmitItems(BulkAddForm sender, IEnumerable<ILevelConfig>? items);

        internal event SubmitItems? OnSubmitted;

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = new List<ILevelConfig>();
            var items = InputRichTextBox.Text.Split('\n',',').ToList();
            items = items.Where(i => !string.IsNullOrEmpty(i)).Select(i => string.Concat(i.Trim('"', ':', '.', ' ').TakeWhile(c => c != '"'))).ToList();


            foreach (var item in items)
            {
                var segments = item.Split('.', ':');
                ILevelConfig newConfig;

                switch(segments[0])
                {
                    case "block":
                        newConfig = new BlockLevelConfig();
                        break;
                    case "item":
                        newConfig = new ItemLevelConfig();
                        break;
                    case "entity":
                        newConfig = new EntityLevelConfig();
                        break;
                    default:
                        continue;
                }

                newConfig.ModId = segments[1];
                newConfig.Name = segments[2];

                newConfig.TrySetLevel(LevelNumericSelector.Value);

                if (SkillsComboBox.SelectedItem is Skills selectedSkill)
                {
                    newConfig.TrySetSkill(selectedSkill);
                }

                result.Add(newConfig);
            }

            if (OnSubmitted != null)
            {
                OnSubmitted.Invoke(this, result);
            }
        }
    }
}
