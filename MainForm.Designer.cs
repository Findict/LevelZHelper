namespace LevelZHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ExportButton = new Button();
            ObjectsListBox = new ListBox();
            DeleteButton = new Button();
            ItemPanel = new Panel();
            MaterialLabel = new Label();
            MaterialTextBox = new TextBox();
            ToSmithingButton = new Button();
            DuplicateButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            LevelLabel = new Label();
            LevelNumericSelector = new NumericUpDown();
            ModKeyTextBox = new TextBox();
            ModKeyLabel = new Label();
            SkillSelector = new Controls.SkillSelectorControl();
            ObjectTypeLabel = new Label();
            ImportButton = new Button();
            SortButton = new Button();
            ClearButton = new Button();
            AddItemButton = new Button();
            AddBlockButton = new Button();
            AddEntityButton = new Button();
            AddMiningButton = new Button();
            AddSmithingButton = new Button();
            AddBrewingButton = new Button();
            BulkAddButton = new Button();
            TemplateButton = new Button();
            ConvertButton = new Button();
            MetadataValuesControl = new Controls.MetadataControl();
            AddMaterialItemButton = new Button();
            SearchTextBox = new TextBox();
            ResetSearchButton = new FontAwesome.Sharp.IconButton();
            ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).BeginInit();
            SuspendLayout();
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(654, 732);
            ExportButton.Margin = new Padding(1);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(153, 23);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // ObjectsListBox
            // 
            ObjectsListBox.Font = new Font("Consolas", 9F);
            ObjectsListBox.FormattingEnabled = true;
            ObjectsListBox.ItemHeight = 14;
            ObjectsListBox.Location = new Point(12, 40);
            ObjectsListBox.Name = "ObjectsListBox";
            ObjectsListBox.ScrollAlwaysVisible = true;
            ObjectsListBox.SelectionMode = SelectionMode.MultiExtended;
            ObjectsListBox.Size = new Size(481, 746);
            ObjectsListBox.Sorted = true;
            ObjectsListBox.TabIndex = 0;
            ObjectsListBox.SelectedIndexChanged += ObjectsListBox_SelectedIndexChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(205, 234);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(98, 23);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ItemPanel
            // 
            ItemPanel.BorderStyle = BorderStyle.FixedSingle;
            ItemPanel.Controls.Add(SkillSelector);
            ItemPanel.Controls.Add(MaterialLabel);
            ItemPanel.Controls.Add(MaterialTextBox);
            ItemPanel.Controls.Add(ToSmithingButton);
            ItemPanel.Controls.Add(DuplicateButton);
            ItemPanel.Controls.Add(NameLabel);
            ItemPanel.Controls.Add(NameTextBox);
            ItemPanel.Controls.Add(LevelLabel);
            ItemPanel.Controls.Add(LevelNumericSelector);
            ItemPanel.Controls.Add(ModKeyTextBox);
            ItemPanel.Controls.Add(ModKeyLabel);
            ItemPanel.Controls.Add(DeleteButton);
            ItemPanel.Location = new Point(499, 369);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(308, 263);
            ItemPanel.TabIndex = 7;
            // 
            // MaterialLabel
            // 
            MaterialLabel.AutoSize = true;
            MaterialLabel.Location = new Point(3, 102);
            MaterialLabel.Name = "MaterialLabel";
            MaterialLabel.Size = new Size(50, 15);
            MaterialLabel.TabIndex = 16;
            MaterialLabel.Text = "Material";
            // 
            // MaterialTextBox
            // 
            MaterialTextBox.Location = new Point(93, 99);
            MaterialTextBox.Name = "MaterialTextBox";
            MaterialTextBox.Size = new Size(210, 23);
            MaterialTextBox.TabIndex = 15;
            MaterialTextBox.TextChanged += MaterialTextBox_TextChanged;
            // 
            // ToSmithingButton
            // 
            ToSmithingButton.Location = new Point(3, 234);
            ToSmithingButton.Name = "ToSmithingButton";
            ToSmithingButton.Size = new Size(98, 23);
            ToSmithingButton.TabIndex = 4;
            ToSmithingButton.Text = "Smithing";
            ToSmithingButton.UseVisualStyleBackColor = true;
            ToSmithingButton.Click += ToSmithingButton_Click;
            // 
            // DuplicateButton
            // 
            DuplicateButton.Location = new Point(104, 234);
            DuplicateButton.Name = "DuplicateButton";
            DuplicateButton.Size = new Size(98, 23);
            DuplicateButton.TabIndex = 5;
            DuplicateButton.Text = "Duplicate";
            DuplicateButton.UseVisualStyleBackColor = true;
            DuplicateButton.Click += DuplicateButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Item name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(93, 41);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(210, 23);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(3, 72);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 8;
            LevelLabel.Text = "Level";
            // 
            // LevelNumericSelector
            // 
            LevelNumericSelector.Location = new Point(93, 70);
            LevelNumericSelector.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            LevelNumericSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.Name = "LevelNumericSelector";
            LevelNumericSelector.Size = new Size(210, 23);
            LevelNumericSelector.TabIndex = 3;
            LevelNumericSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.ValueChanged += LevelNumericSelector_ValueChanged;
            // 
            // ModKeyTextBox
            // 
            ModKeyTextBox.Location = new Point(93, 12);
            ModKeyTextBox.Name = "ModKeyTextBox";
            ModKeyTextBox.Size = new Size(210, 23);
            ModKeyTextBox.TabIndex = 0;
            ModKeyTextBox.TextChanged += ModKeyTextBox_TextChanged;
            // 
            // ModKeyLabel
            // 
            ModKeyLabel.AutoSize = true;
            ModKeyLabel.Location = new Point(3, 15);
            ModKeyLabel.Name = "ModKeyLabel";
            ModKeyLabel.Size = new Size(53, 15);
            ModKeyLabel.TabIndex = 9;
            ModKeyLabel.Text = "Mod key";
            // 
            // ObjectTypeLabel
            // 
            ObjectTypeLabel.AutoSize = true;
            ObjectTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ObjectTypeLabel.Location = new Point(503, 361);
            ObjectTypeLabel.Name = "ObjectTypeLabel";
            ObjectTypeLabel.Size = new Size(34, 15);
            ObjectTypeLabel.TabIndex = 16;
            ObjectTypeLabel.Text = "Item";
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(499, 732);
            ImportButton.Margin = new Padding(1);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(153, 23);
            ImportButton.TabIndex = 8;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(499, 757);
            SortButton.Margin = new Padding(1);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(153, 23);
            SortButton.TabIndex = 12;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(654, 757);
            ClearButton.Margin = new Padding(1);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(153, 23);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Image = Properties.Resources.item_icon;
            AddItemButton.Location = new Point(499, 661);
            AddItemButton.Margin = new Padding(0, 1, 0, 1);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(44, 44);
            AddItemButton.TabIndex = 18;
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // AddBlockButton
            // 
            AddBlockButton.Image = Properties.Resources.block_icon;
            AddBlockButton.Location = new Point(587, 661);
            AddBlockButton.Margin = new Padding(0, 1, 0, 1);
            AddBlockButton.Name = "AddBlockButton";
            AddBlockButton.Size = new Size(44, 44);
            AddBlockButton.TabIndex = 19;
            AddBlockButton.UseVisualStyleBackColor = true;
            AddBlockButton.Click += AddBlockButton_Click;
            // 
            // AddEntityButton
            // 
            AddEntityButton.Image = Properties.Resources.entity_icon;
            AddEntityButton.Location = new Point(631, 661);
            AddEntityButton.Margin = new Padding(0, 1, 0, 1);
            AddEntityButton.Name = "AddEntityButton";
            AddEntityButton.Size = new Size(44, 44);
            AddEntityButton.TabIndex = 20;
            AddEntityButton.UseVisualStyleBackColor = true;
            AddEntityButton.Click += AddEntityButton_Click;
            // 
            // AddMiningButton
            // 
            AddMiningButton.Image = Properties.Resources.mining_icon;
            AddMiningButton.Location = new Point(675, 661);
            AddMiningButton.Margin = new Padding(0, 1, 0, 1);
            AddMiningButton.Name = "AddMiningButton";
            AddMiningButton.Size = new Size(44, 44);
            AddMiningButton.TabIndex = 21;
            AddMiningButton.UseVisualStyleBackColor = true;
            AddMiningButton.Click += AddMiningButton_Click;
            // 
            // AddSmithingButton
            // 
            AddSmithingButton.Image = Properties.Resources.smithing_icon;
            AddSmithingButton.Location = new Point(719, 661);
            AddSmithingButton.Margin = new Padding(0, 1, 0, 1);
            AddSmithingButton.Name = "AddSmithingButton";
            AddSmithingButton.Size = new Size(44, 44);
            AddSmithingButton.TabIndex = 22;
            AddSmithingButton.UseVisualStyleBackColor = true;
            AddSmithingButton.Click += AddSmithingButton_Click;
            // 
            // AddBrewingButton
            // 
            AddBrewingButton.Image = Properties.Resources.brewing_icon;
            AddBrewingButton.Location = new Point(763, 661);
            AddBrewingButton.Margin = new Padding(0, 1, 0, 1);
            AddBrewingButton.Name = "AddBrewingButton";
            AddBrewingButton.Size = new Size(44, 44);
            AddBrewingButton.TabIndex = 23;
            AddBrewingButton.UseVisualStyleBackColor = true;
            AddBrewingButton.Click += AddBrewingButton_Click;
            // 
            // BulkAddButton
            // 
            BulkAddButton.Location = new Point(499, 707);
            BulkAddButton.Margin = new Padding(1);
            BulkAddButton.Name = "BulkAddButton";
            BulkAddButton.Size = new Size(153, 23);
            BulkAddButton.TabIndex = 24;
            BulkAddButton.Text = "Bulk add";
            BulkAddButton.UseVisualStyleBackColor = true;
            BulkAddButton.Click += BulkAddButton_Click;
            // 
            // TemplateButton
            // 
            TemplateButton.Location = new Point(654, 707);
            TemplateButton.Margin = new Padding(1);
            TemplateButton.Name = "TemplateButton";
            TemplateButton.Size = new Size(153, 23);
            TemplateButton.TabIndex = 25;
            TemplateButton.Text = "Template";
            TemplateButton.UseVisualStyleBackColor = true;
            TemplateButton.Click += TemplateButton_Click;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(499, 636);
            ConvertButton.Margin = new Padding(1);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(308, 23);
            ConvertButton.TabIndex = 17;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // MetadataValuesControl
            // 
            MetadataValuesControl.Location = new Point(499, 12);
            MetadataValuesControl.Name = "MetadataValuesControl";
            MetadataValuesControl.Size = new Size(308, 351);
            MetadataValuesControl.TabIndex = 26;
            // 
            // AddMaterialItemButton
            // 
            AddMaterialItemButton.Image = Properties.Resources.material_item_icon;
            AddMaterialItemButton.Location = new Point(543, 661);
            AddMaterialItemButton.Margin = new Padding(0, 1, 0, 1);
            AddMaterialItemButton.Name = "AddMaterialItemButton";
            AddMaterialItemButton.Size = new Size(44, 44);
            AddMaterialItemButton.TabIndex = 27;
            AddMaterialItemButton.UseVisualStyleBackColor = true;
            AddMaterialItemButton.Click += AddMaterialItemButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(12, 12);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search...";
            SearchTextBox.Size = new Size(455, 23);
            SearchTextBox.TabIndex = 18;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // ResetSearchButton
            // 
            ResetSearchButton.Cursor = Cursors.Hand;
            ResetSearchButton.Enabled = false;
            ResetSearchButton.FlatAppearance.BorderSize = 0;
            ResetSearchButton.FlatStyle = FlatStyle.Flat;
            ResetSearchButton.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            ResetSearchButton.IconColor = Color.Red;
            ResetSearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ResetSearchButton.IconSize = 23;
            ResetSearchButton.Location = new Point(470, 12);
            ResetSearchButton.Margin = new Padding(0, 3, 3, 3);
            ResetSearchButton.Name = "ResetSearchButton";
            ResetSearchButton.Size = new Size(23, 23);
            ResetSearchButton.TabIndex = 28;
            ResetSearchButton.UseVisualStyleBackColor = true;
            ResetSearchButton.Click += ResetSearchButton_Click;
            // 
            // SkillSelector
            // 
            SkillSelector.Location = new Point(3, 128);
            SkillSelector.Name = "SkillSelector";
            SkillSelector.Size = new Size(300, 100);
            SkillSelector.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 800);
            Controls.Add(ResetSearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(AddMaterialItemButton);
            Controls.Add(MetadataValuesControl);
            Controls.Add(BulkAddButton);
            Controls.Add(TemplateButton);
            Controls.Add(AddBrewingButton);
            Controls.Add(AddSmithingButton);
            Controls.Add(AddMiningButton);
            Controls.Add(AddEntityButton);
            Controls.Add(AddBlockButton);
            Controls.Add(AddItemButton);
            Controls.Add(ClearButton);
            Controls.Add(ConvertButton);
            Controls.Add(ObjectTypeLabel);
            Controls.Add(SortButton);
            Controls.Add(ImportButton);
            Controls.Add(ObjectsListBox);
            Controls.Add(ItemPanel);
            Controls.Add(ExportButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Level Z Add-on Tool";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModKeyLabel;
        private Panel ItemPanel;
        private Label NameLabel;
        private Label LevelLabel;
        private TextBox NameTextBox;
        private NumericUpDown LevelNumericSelector;
        private ListBox ObjectsListBox;
        private Button DeleteButton;
        private Button ExportButton;
        private TextBox ModKeyTextBox;
        private Label ObjectTypeLabel;
        private Button ImportButton;
        private Button SortButton;
        private Button ToSmithingButton;
        private Button DuplicateButton;
        private Button ClearButton;
        private Button AddItemButton;
        private Button AddBlockButton;
        private Button AddEntityButton;
        private Button AddMiningButton;
        private Button AddSmithingButton;
        private Button AddBrewingButton;
        private Label MaterialLabel;
        private TextBox MaterialTextBox;
        private Button BulkAddButton;
        private Button TemplateButton;
        private Button ConvertButton;
        private Controls.MetadataControl MetadataValuesControl;
        private Button AddMaterialItemButton;
        private TextBox SearchTextBox;
        private FontAwesome.Sharp.IconButton ResetSearchButton;
        private Controls.SkillSelectorControl SkillSelector;
    }
}
