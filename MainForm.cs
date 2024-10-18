using LevelZHelper.Controls;
using LevelZHelper.Managers;
using LevelZHelper.Models;
using LevelZHelper.Models.Enums;
using LevelZHelper.Models.LevelConfigs.Interfaces;
using LevelZHelper.Models.Templating;
using LevelZHelper.Views;

namespace LevelZHelper
{
    public partial class MainForm : Form
    {
        private readonly LevelConfigManager _configManager;

        private List<ILevelConfig>? _activeItems;
        private TemplatingForm? _templatingForm;
        private BulkAddForm? _bulkAddForm;
        private bool _lockIndices = false;
        private bool _convert = false;

        public MainForm()
        {
            InitializeComponent();

            _configManager = new LevelConfigManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var itemContextMenu = new ContextMenuStrip();

            AddItemButton.ContextMenuStrip = itemContextMenu;

            MetadataValuesControl.OnMetadataSubmitted += OnMetadataUpdate;
            SkillSelector.ActiveSkillChanged += OnSkillChanged;

            EmptyForm();
        }

        private void OnMetadataUpdate(MetadataControl sender, AddOnMetadata metadata)
        {
            _configManager.Metadata = metadata;
        }

        private void EmptyForm()
        {
            _activeItems = null;
            NameTextBox.Text = string.Empty;
            SkillSelector.SetValue(Skills.None);
            LevelNumericSelector.Value = 1;
            MaterialTextBox.Text = string.Empty;

            SetEnabled();
        }

        private void ObjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lockIndices) return;

            if (sender is ListBox listBox)
            {
                var selectedIndices = listBox.SelectedIndices.Count;

                _activeItems = new List<ILevelConfig>();

                foreach (var item in ObjectsListBox.SelectedItems)
                {
                    if (item is ILevelConfig levelConfig)
                    {
                        _activeItems.Add(levelConfig);
                    }
                }

                var prototype = _activeItems.FirstOrDefault();

                if (prototype == null)
                {
                    ModKeyTextBox.Text = string.Empty;
                    NameTextBox.Text = string.Empty;
                    SkillSelector.SetValue(Skills.None);
                    LevelNumericSelector.Value = 1;
                    MaterialTextBox.Text = string.Empty;
                    ObjectTypeLabel.Text = string.Empty;
                }
                else
                {
                    if (_activeItems.All(s => s.ModId == prototype.ModId)) ModKeyTextBox.Text = prototype.ModId;
                    if (_activeItems.All(s => s.Name == prototype.Name)) NameTextBox.Text = prototype.Name;
                    if (_activeItems.All(s => s.Level == prototype.Level)) LevelNumericSelector.Value = prototype.Level;
                    if (_activeItems.All(s => s.Material == prototype.Material)) MaterialTextBox.Text = prototype.Material;

                    if (_activeItems.All(s => s.Skill == prototype.Skill)) SkillSelector.SetValue(prototype.Skill);
                    else SkillSelector.SetValue(Skills.None);

                    ObjectTypeLabel.Text = _activeItems.All(s => s.TypeString == prototype.TypeString) ? prototype.TypeString : "Objects";
                }

                SetEnabled();
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_activeItems != null && _activeItems.Count != 0)
            {
                var minIndex = _activeItems.Min(ObjectsListBox.Items.IndexOf);
                var remainingItems = ObjectsListBox.Items.Count - _activeItems.Count;

                var targetIndex = remainingItems == 0 ? -1 :
                                  remainingItems - 1 >= minIndex ? minIndex : remainingItems - 1;

                foreach (var item in _activeItems)
                {
                    if (!_configManager.DeleteItem(item)) continue;
                    ObjectsListBox.Items.Remove(item);
                }

                if (targetIndex == -1)
                {
                    EmptyForm();
                }
                else
                {
                    ObjectsListBox.SelectedIndex = targetIndex;
                }
            }
        }

        private void ModKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _activeItems != null && _activeItems.Count != 0)
            {
                var selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Replace(" ", "_");
                textBox.SelectionStart = selectionStart;

                foreach (var item in _activeItems)
                {
                    item.ModId = textBox.Text;
                }

                UpdateSelectedItems();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _activeItems != null && _activeItems.Count != 0)
            {
                var selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Replace(" ", "_");
                textBox.SelectionStart = selectionStart;

                foreach (var item in _activeItems)
                {
                    item.Name = textBox.Text;
                }

                UpdateSelectedItems();
            }
        }

        private void OnSkillChanged(object sender, Skills skill)
        {
            if (_activeItems != null && _activeItems.Count != 0)
            {
                foreach (var item in _activeItems)
                {
                    item.TrySetSkill(skill);
                }

                UpdateSelectedItems();
            }
        }

        private void LevelNumericSelector_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown numericBox && _activeItems != null && _activeItems.Count != 0)
            {
                foreach (var item in _activeItems)
                {
                    item.TrySetLevel(numericBox.Value);
                }

                UpdateSelectedItems();
            }
        }

        private void MaterialTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && _activeItems != null && _activeItems.Count != 0)
            {
                var selectionStart = textBox.SelectionStart;
                textBox.Text = textBox.Text.Replace(" ", "_");
                textBox.SelectionStart = selectionStart;

                foreach (var item in _activeItems)
                {
                    item.Material = textBox.Text;
                }

                UpdateSelectedItems();
            }
        }

        private void ToSmithingButton_Click(object sender, EventArgs e)
        {
            AddSmithingDuplicate();
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            DuplicateItems();

            NameTextBox.Focus();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            DisableAll();

            using var dialog = new SaveFileDialog();

            var metadata = _configManager.Metadata;

            dialog.Filter = "Jar file|*.jar";
            dialog.DefaultExt = "jar";
            dialog.FileName = $"{metadata?.Name?.ToLower().Replace(" ", "_") ?? "no_name"}-{metadata?.Version ?? "0.0"}.jar";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _configManager.ExportAll(dialog);
            }

            SetEnabled();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            DisableAll();

            using var dialog = new OpenFileDialog();

            dialog.Filter = "Jar file|*.jar";
            dialog.Multiselect = false;

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                _configManager.ImportAll(dialog.FileName);

                RefreshMetaData();
                RefreshList();
            }

            SetEnabled();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear the list?", "Confirm Clear All", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            _configManager.ClearAll();
            MetadataValuesControl.UpdateMetadata(_configManager.Metadata);

            ObjectsListBox.Items.Clear();

            _activeItems = null;

            ModKeyTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            SkillSelector.SetValue(Skills.None);
            LevelNumericSelector.Value = 1;
            MaterialTextBox.Text = string.Empty;

            SetEnabled();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Multiply:
                    if (ActiveControl is not TextBox && ActiveControl is not RichTextBox) DuplicateItems();
                    break;
                case Keys.Add:
                    if (ActiveControl is not TextBox && ActiveControl is not RichTextBox) MoveSelection(1);
                    break;
                case Keys.Subtract:
                    if (ActiveControl is not TextBox && ActiveControl is not RichTextBox) MoveSelection(-1);
                    break;
                case Keys.Divide:
                    if (ActiveControl is not TextBox && ActiveControl is not RichTextBox) AddSmithingDuplicate();
                    break;
                case Keys.F12:
                    TemplateButton_Click(sender, e);
                    break;
                case Keys.Delete:
                    if (ActiveControl is not TextBox && ActiveControl is not RichTextBox && ActiveControl is not ComboBox && ActiveControl is not NumericUpDown) DeleteButton_Click(this, e);
                    break;
                case Keys.Escape:
                    if (ActiveControl == null || ActiveControl == SearchTextBox) SearchTextBox.Text = string.Empty;
                    ActiveControl = null;
                    break;
            }
        }

        private void AddTemplatedItems(TemplatingForm sender, ITemplate template)
        {
            _configManager.AddItemsFromTemplate(template);

            RefreshList();

            sender.Close();
            sender.Dispose();
        }

        private void BulkAddItems(BulkAddForm sender, IEnumerable<ILevelConfig>? items)
        {
            if (items != null)
            {
                _configManager.AppendItems(items);

                RefreshList();

                _lockIndices = true;

                ObjectsListBox.SelectedItems.Clear();

                foreach (var item in items)
                {
                    ObjectsListBox.SelectedItems.Add(item);
                }

                _lockIndices = false;

                ObjectsListBox_SelectedIndexChanged(ObjectsListBox, new EventArgs());
            }

            sender.Close();
            sender.Dispose();
        }

        private void AddItem(ConfigType configType)
        {
            if (_convert)
            {
                ConvertSelectedItems(configType);

                ConvertButton_Click(ConvertButton, new EventArgs());

                return;
            }

            var newItem = _configManager.AddItem(configType);

            if (newItem == null) return;

            newItem.ModId = ModKeyTextBox.Text;

            ObjectsListBox.Items.Add(newItem);

            _lockIndices = true;

            ObjectsListBox.SelectedItems.Clear();

            _lockIndices = false;

            ObjectsListBox.SelectedItems.Add(newItem);

            NameTextBox.Focus();
        }

        private void ConvertSelectedItems(ConfigType configType)
        {
            if (_activeItems == null) return;

            _lockIndices = true;

            ObjectsListBox.SelectedItems.Clear();

            foreach (var item in _activeItems.Where(i => i.ConfigType != configType))
            {
                var newItem = _configManager.AddItem(configType);

                if (newItem == null) continue;

                newItem.ModId = item.ModId;
                newItem.Name = item.Name;
                newItem.TrySetSkill(item.Skill);
                newItem.TrySetLevel(item.Level);
                newItem.Material = item.Material;

                ObjectsListBox.Items.Add(newItem);
                ObjectsListBox.SelectedItems.Add(newItem);

                _configManager.DeleteItem(item);
                ObjectsListBox.Items.Remove(item);
            }

            _lockIndices = false;

            ObjectsListBox_SelectedIndexChanged(ObjectsListBox, new EventArgs());
        }

        private void AddSmithingDuplicate()
        {
            if (_activeItems == null || _activeItems.Count == 0) return;

            _lockIndices = true;

            ObjectsListBox.SelectedItems.Clear();

            foreach (var item in _activeItems.Where(i => i.ConfigType == ConfigType.Item))
            {
                var newItem = _configManager.AddItem(ConfigType.Smithing);

                if (newItem == null) return;

                newItem.ModId = item.ModId;
                newItem.Name = item.Name;
                newItem.TrySetSkill(item.Skill);
                newItem.TrySetLevel(item.Level);

                ObjectsListBox.Items.Add(newItem);
                ObjectsListBox.SelectedItems.Add(newItem);
            }

            _lockIndices = false;

            ObjectsListBox_SelectedIndexChanged(ObjectsListBox, new EventArgs());
        }

        private void RefreshMetaData()
        {
            MetadataValuesControl.UpdateMetadata(_configManager.Metadata);
        }

        private void RefreshList()
        {
            _lockIndices = true;

            ObjectsListBox.Items.Clear();

            foreach (var config in _configManager.GetConfigs(SearchTextBox.Text))
            {
                ObjectsListBox.Items.Add(config);
            }

            if (_activeItems != null)
            {
                foreach (var item in _activeItems)
                {
                    ObjectsListBox.SelectedItems.Add(item);
                }
            }

            _lockIndices = false;

            ObjectsListBox_SelectedIndexChanged(ObjectsListBox, new EventArgs());
        }

        private void UpdateSelectedItems()
        {
            var indexList = new List<int>();

            foreach (int item in ObjectsListBox.SelectedIndices)
            {
                indexList.Add(item);
            }

            if (indexList.Count == 0) return;

            _lockIndices = true;

            foreach (int index in indexList)
            {
                ObjectsListBox.Items[index] = ObjectsListBox.Items[index];
            }

            foreach (var item in indexList)
            {
                ObjectsListBox.SelectedIndices.Add(item);
            }

            _lockIndices = false;
        }

        private void MoveSelection(int change)
        {
            var count = ObjectsListBox.Items.Count;

            if (count == 0) return;

            var newIndex = ObjectsListBox.SelectedIndex + change;

            while (newIndex < 0) newIndex += count;

            ObjectsListBox.SelectedIndex = newIndex % count;
        }

        private void SetEnabled()
        {
            ObjectsListBox.Enabled = true;

            ModKeyTextBox.Enabled = _activeItems != null && _activeItems.Count != 0 && _activeItems.Any(i => (i.AllowedFields & EditFields.ModKey) > 0);
            NameTextBox.Enabled = _activeItems != null && _activeItems.Count != 0 && _activeItems.Any(i => (i.AllowedFields & EditFields.Name) > 0);
            SkillSelector.SetActive(_activeItems != null && _activeItems.Count != 0 && _activeItems.Any(i => (i.AllowedFields & EditFields.Skill) > 0));
            LevelNumericSelector.Enabled = _activeItems != null && _activeItems.Count != 0 && _activeItems.Any(i => (i.AllowedFields & EditFields.Level) > 0);
            MaterialTextBox.Enabled = _activeItems != null && _activeItems.Count != 0 && _activeItems.Any(i => (i.AllowedFields & EditFields.Material) > 0);
            ToSmithingButton.Enabled = _activeItems != null && _activeItems.Count != 0 && _activeItems.Any(i => (i.AllowedFields & EditFields.ToSmithing) > 0);
            DuplicateButton.Enabled = _activeItems != null && _activeItems.Count != 0;
            DeleteButton.Enabled = _activeItems != null && _activeItems.Count != 0;
            ConvertButton.Enabled = _activeItems != null && _activeItems.Count != 0;

            AddItemButton.Enabled = true;
            AddBlockButton.Enabled = true;
            AddEntityButton.Enabled = true;
            AddSmithingButton.Enabled = true;
            AddMiningButton.Enabled = true;
            AddBrewingButton.Enabled = true;

            ImportButton.Enabled = true;
            ExportButton.Enabled = true;
            SortButton.Enabled = true;
            ClearButton.Enabled = true;
        }

        private void DisableAll()
        {
            ObjectsListBox.Enabled = false;

            ModKeyTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            SkillSelector.SetActive(false);
            LevelNumericSelector.Enabled = false;
            MaterialTextBox.Enabled = false;
            ToSmithingButton.Enabled = false;
            DuplicateButton.Enabled = false;
            DeleteButton.Enabled = false;

            AddItemButton.Enabled = false;
            AddBlockButton.Enabled = false;
            AddEntityButton.Enabled = false;
            AddSmithingButton.Enabled = false;
            AddMiningButton.Enabled = false;
            AddBrewingButton.Enabled = false;

            ImportButton.Enabled = false;
            ExportButton.Enabled = false;
            SortButton.Enabled = false;
            ClearButton.Enabled = false;
        }

        private void DuplicateItems()
        {
            if (_activeItems == null || _activeItems.Count == 0) return;

            _lockIndices = true;

            ObjectsListBox.SelectedItems.Clear();

            foreach (var item in _activeItems)
            {
                var newItem = _configManager.AddItem(item.ConfigType);

                if (newItem == null) continue;

                newItem.ModId = item.ModId;
                newItem.Name = item.Name;
                newItem.TrySetSkill(item.Skill);
                newItem.TrySetLevel(item.Level);
                newItem.Material = item.Material;

                ObjectsListBox.Items.Add(newItem);
                ObjectsListBox.SelectedItems.Add(newItem);
            }

            _lockIndices = false;

            ObjectsListBox_SelectedIndexChanged(ObjectsListBox, new EventArgs());
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.Item);
        }

        private void AddMaterialItemButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.MaterialItem);
        }

        private void AddBlockButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.Block);
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.Entity);
        }

        private void AddMiningButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.Mining);
        }

        private void AddSmithingButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.Smithing);
        }

        private void AddBrewingButton_Click(object sender, EventArgs e)
        {
            AddItem(ConfigType.Brewing);
        }

        private void TemplateButton_Click(object sender, EventArgs e)
        {
            _templatingForm = new TemplatingForm();
            _templatingForm.OnTemplatesSubmitted += AddTemplatedItems;
            _templatingForm.Configure(ModKeyTextBox.Text);
            _templatingForm.Show();
        }

        private void BulkAddButton_Click(object sender, EventArgs e)
        {
            _bulkAddForm = new BulkAddForm();
            _bulkAddForm.OnSubmitted += BulkAddItems;
            _bulkAddForm.Show();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (sender is Button convertButton)
            {
                if (_convert)
                {
                    _convert = false;
                    convertButton.BackColor = SystemColors.Control;
                    convertButton.UseVisualStyleBackColor = true;
                }
                else
                {
                    _convert = true;
                    convertButton.BackColor = SystemColors.ControlDarkDark;
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox searchBar)
            {
                ResetSearchButton.Enabled = !string.IsNullOrEmpty(searchBar.Text);

                var foundItems = _configManager.GetConfigs(searchBar.Text);
                var itemsToDelete = new List<ILevelConfig>();

                _lockIndices = true;

                foreach (ILevelConfig item in ObjectsListBox.Items)
                {
                    if (foundItems.Contains(item))
                    {
                        foundItems.Remove(item);

                        continue;
                    }

                    itemsToDelete.Add(item);
                }

                foreach (var item in itemsToDelete)
                {
                    ObjectsListBox.Items.Remove(item);
                }

                ObjectsListBox.Items.AddRange(foundItems.ToArray());

                _lockIndices = false;

                ObjectsListBox_SelectedIndexChanged(ObjectsListBox, e);
            }
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = string.Empty;
        }
    }
}
