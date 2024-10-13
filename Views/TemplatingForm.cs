using LevelZHelper.Models.Enums;
using LevelZHelper.Models.Templating;

namespace LevelZHelper.Views
{
    public partial class TemplatingForm : Form
    {
        private ITemplate? _template;

        public TemplatingForm()
        {
            InitializeComponent();
        }

        public void Configure(string modKey)
        {
            if (_template != null)
            {
                _template.ModKey = modKey;
            }

            ModKeyTextBox.Text = modKey;

            UpdatePreviewBox();
        }

        private void TemplatingForm_Load(object sender, EventArgs e)
        {
            SkillsComboBox.DataSource = Enum.GetValues(typeof(Skills));

            _template = new ArmorTemplate();
            _template.Configure();
            _template.ModKey = ModKeyTextBox.Text;

            SetEnabled();
            UpdatePreviewBox();
        }

        internal delegate void SubmitTemplatedItems(TemplatingForm sender, ITemplate template);

        internal event SubmitTemplatedItems? OnTemplatesSubmitted;

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (_template != null && OnTemplatesSubmitted != null)
            {
                OnTemplatesSubmitted.Invoke(this, _template);
            }
        }

        private void ModKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _template != null)
            {
                _template.ModKey = textBox.Text;
                UpdatePreviewBox();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _template != null)
            {
                _template.BaseName = textBox.Text;
                UpdatePreviewBox();
            }
        }

        private void SkillsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is Skills selectedSkill && _template != null)
            {
                _template.Skill = selectedSkill;
                UpdatePreviewBox();
            }
        }

        private void LevelNumericSelector_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericBox && _template != null)
            {
                _template.Level = (int)numericBox.Value;
                UpdatePreviewBox();
            }
        }

        private void MaterialTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _template != null)
            {
                _template.Material = textBox.Text;
                UpdatePreviewBox();
            }
        }

        private void TemplateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is TemplateType templateType)
            {
                if (_template != null && templateType == _template.TypeValue) return;

                switch (templateType)
                {
                    case TemplateType.Armor:
                        _template = new ArmorTemplate();
                        break;
                    case TemplateType.MaterialToolSet:
                        _template = new MaterialToolTemplate();
                        break;
                    default:
                        return;
                }

                _template.Configure();

                SynchronizeTemplate();
                SetEnabled();
                UpdatePreviewBox();
            }
        }

        private void UpdatePreviewBox()
        {
            if (_template == null) return;

            PreviewRichTextBox.Lines = _template.ToString()?.Split("\r\n");
        }

        private void SynchronizeTemplate()
        {
            if (_template == null) return;

            if ((_template.EnabledFields & EditFields.ModKey) > 0)
                 _template.ModKey = ModKeyTextBox.Text;
            else ModKeyTextBox.Text = _template.ModKey;

            if ((_template.EnabledFields & EditFields.Name) > 0)
                _template.BaseName = NameTextBox.Text;
            else NameTextBox.Text = _template.BaseName;

            if ((_template.EnabledFields & EditFields.Skill) > 0 && SkillsComboBox.SelectedItem is Skills selectedSkill)
                _template.Skill = selectedSkill;
            else SkillsComboBox.SelectedItem = _template.Skill;

            if ((_template.EnabledFields & EditFields.Level) > 0)
                _template.Level = (int)LevelNumericSelector.Value;
            else LevelNumericSelector.Value = _template.Level;

            if ((_template.EnabledFields & EditFields.Material) > 0)
                _template.Material = MaterialTextBox.Text;
            else MaterialTextBox.Text = _template.Material;
        }

        private void SetEnabled()
        {
            ModKeyTextBox.Enabled = (_template?.EnabledFields & EditFields.ModKey) > 0;
            NameTextBox.Enabled = (_template?.EnabledFields & EditFields.Name) > 0;
            SkillsComboBox.Enabled = (_template?.EnabledFields & EditFields.Skill) > 0;
            LevelNumericSelector.Enabled = (_template?.EnabledFields & EditFields.Level) > 0;
            MaterialTextBox.Enabled = (_template?.EnabledFields & EditFields.Material) > 0;
        }
    }
}
