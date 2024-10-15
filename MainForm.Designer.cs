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
            SkillLabel = new Label();
            NameTextBox = new TextBox();
            LevelLabel = new Label();
            LevelNumericSelector = new NumericUpDown();
            SkillsComboBox = new ComboBox();
            ModKeyTextBox = new TextBox();
            ModKeyLabel = new Label();
            ObjectTypeLabel = new Label();
            ImportButton = new Button();
            SortButton = new Button();
            AddOnNameTextBox = new TextBox();
            AddOnNameLabel = new Label();
            AuthorTextBox = new TextBox();
            AuthorLabel = new Label();
            AddOnIdTextBox = new TextBox();
            AddOnIdLabel = new Label();
            DescriptionLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            VersionTextBox = new TextBox();
            VersionLabel = new Label();
            IconImageBox = new PictureBox();
            IconLabel = new Label();
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
            ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconImageBox).BeginInit();
            SuspendLayout();
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(619, 628);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(120, 23);
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
            ObjectsListBox.Location = new Point(12, 12);
            ObjectsListBox.Name = "ObjectsListBox";
            ObjectsListBox.ScrollAlwaysVisible = true;
            ObjectsListBox.SelectionMode = SelectionMode.MultiExtended;
            ObjectsListBox.Size = new Size(481, 662);
            ObjectsListBox.Sorted = true;
            ObjectsListBox.TabIndex = 0;
            ObjectsListBox.SelectedIndexChanged += ObjectsListBox_SelectedIndexChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(159, 157);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(76, 23);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ItemPanel
            // 
            ItemPanel.BorderStyle = BorderStyle.FixedSingle;
            ItemPanel.Controls.Add(MaterialLabel);
            ItemPanel.Controls.Add(MaterialTextBox);
            ItemPanel.Controls.Add(ToSmithingButton);
            ItemPanel.Controls.Add(DuplicateButton);
            ItemPanel.Controls.Add(NameLabel);
            ItemPanel.Controls.Add(SkillLabel);
            ItemPanel.Controls.Add(NameTextBox);
            ItemPanel.Controls.Add(LevelLabel);
            ItemPanel.Controls.Add(LevelNumericSelector);
            ItemPanel.Controls.Add(SkillsComboBox);
            ItemPanel.Controls.Add(ModKeyTextBox);
            ItemPanel.Controls.Add(ModKeyLabel);
            ItemPanel.Controls.Add(DeleteButton);
            ItemPanel.Location = new Point(499, 357);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new Size(240, 186);
            ItemPanel.TabIndex = 7;
            // 
            // MaterialLabel
            // 
            MaterialLabel.AutoSize = true;
            MaterialLabel.Location = new Point(3, 131);
            MaterialLabel.Name = "MaterialLabel";
            MaterialLabel.Size = new Size(50, 15);
            MaterialLabel.TabIndex = 16;
            MaterialLabel.Text = "Material";
            // 
            // MaterialTextBox
            // 
            MaterialTextBox.Location = new Point(93, 128);
            MaterialTextBox.Name = "MaterialTextBox";
            MaterialTextBox.Size = new Size(142, 23);
            MaterialTextBox.TabIndex = 15;
            MaterialTextBox.TextChanged += MaterialTextBox_TextChanged;
            // 
            // ToSmithingButton
            // 
            ToSmithingButton.Location = new Point(3, 157);
            ToSmithingButton.Name = "ToSmithingButton";
            ToSmithingButton.Size = new Size(76, 23);
            ToSmithingButton.TabIndex = 4;
            ToSmithingButton.Text = "Smithing";
            ToSmithingButton.UseVisualStyleBackColor = true;
            ToSmithingButton.Click += ToSmithingButton_Click;
            // 
            // DuplicateButton
            // 
            DuplicateButton.Location = new Point(79, 157);
            DuplicateButton.Name = "DuplicateButton";
            DuplicateButton.Size = new Size(80, 23);
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
            // SkillLabel
            // 
            SkillLabel.AutoSize = true;
            SkillLabel.Location = new Point(3, 73);
            SkillLabel.Name = "SkillLabel";
            SkillLabel.Size = new Size(28, 15);
            SkillLabel.TabIndex = 7;
            SkillLabel.Text = "Skill";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(93, 41);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(142, 23);
            NameTextBox.TabIndex = 1;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(3, 101);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 8;
            LevelLabel.Text = "Level";
            // 
            // LevelNumericSelector
            // 
            LevelNumericSelector.Location = new Point(93, 99);
            LevelNumericSelector.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            LevelNumericSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.Name = "LevelNumericSelector";
            LevelNumericSelector.Size = new Size(142, 23);
            LevelNumericSelector.TabIndex = 3;
            LevelNumericSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.ValueChanged += LevelNumericSelector_ValueChanged;
            // 
            // SkillsComboBox
            // 
            SkillsComboBox.FormattingEnabled = true;
            SkillsComboBox.Location = new Point(93, 70);
            SkillsComboBox.Name = "SkillsComboBox";
            SkillsComboBox.Size = new Size(142, 23);
            SkillsComboBox.TabIndex = 2;
            SkillsComboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged;
            // 
            // ModKeyTextBox
            // 
            ModKeyTextBox.Location = new Point(93, 12);
            ModKeyTextBox.Name = "ModKeyTextBox";
            ModKeyTextBox.Size = new Size(142, 23);
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
            ObjectTypeLabel.Location = new Point(503, 349);
            ObjectTypeLabel.Name = "ObjectTypeLabel";
            ObjectTypeLabel.Size = new Size(34, 15);
            ObjectTypeLabel.TabIndex = 16;
            ObjectTypeLabel.Text = "Item";
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(499, 628);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(120, 23);
            ImportButton.TabIndex = 8;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(499, 651);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(120, 23);
            SortButton.TabIndex = 12;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // AddOnNameTextBox
            // 
            AddOnNameTextBox.Location = new Point(593, 193);
            AddOnNameTextBox.Name = "AddOnNameTextBox";
            AddOnNameTextBox.Size = new Size(146, 23);
            AddOnNameTextBox.TabIndex = 3;
            AddOnNameTextBox.TextChanged += AddOnNameTextBox_TextChanged;
            // 
            // AddOnNameLabel
            // 
            AddOnNameLabel.AutoSize = true;
            AddOnNameLabel.Location = new Point(503, 196);
            AddOnNameLabel.Name = "AddOnNameLabel";
            AddOnNameLabel.Size = new Size(81, 15);
            AddOnNameLabel.TabIndex = 17;
            AddOnNameLabel.Text = "Add-on name";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(593, 251);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(146, 23);
            AuthorTextBox.TabIndex = 5;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(503, 254);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(44, 15);
            AuthorLabel.TabIndex = 15;
            AuthorLabel.Text = "Author";
            // 
            // AddOnIdTextBox
            // 
            AddOnIdTextBox.Location = new Point(593, 164);
            AddOnIdTextBox.Name = "AddOnIdTextBox";
            AddOnIdTextBox.Size = new Size(146, 23);
            AddOnIdTextBox.TabIndex = 2;
            AddOnIdTextBox.TextChanged += AddOnIdTextBox_TextChanged;
            // 
            // AddOnIdLabel
            // 
            AddOnIdLabel.AutoSize = true;
            AddOnIdLabel.Location = new Point(503, 167);
            AddOnIdLabel.Name = "AddOnIdLabel";
            AddOnIdLabel.Size = new Size(61, 15);
            AddOnIdLabel.TabIndex = 14;
            AddOnIdLabel.Text = "Add-on id";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(503, 283);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 13;
            DescriptionLabel.Text = "Description";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(499, 301);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(240, 49);
            DescriptionRichTextBox.TabIndex = 6;
            DescriptionRichTextBox.Text = "";
            DescriptionRichTextBox.TextChanged += DescriptionRichTextBox_TextChanged;
            // 
            // VersionTextBox
            // 
            VersionTextBox.Location = new Point(593, 222);
            VersionTextBox.Name = "VersionTextBox";
            VersionTextBox.Size = new Size(146, 23);
            VersionTextBox.TabIndex = 4;
            VersionTextBox.TextChanged += VersionTextBox_TextChanged;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(503, 225);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(45, 15);
            VersionLabel.TabIndex = 12;
            VersionLabel.Text = "Version";
            // 
            // IconImageBox
            // 
            IconImageBox.BackColor = SystemColors.Window;
            IconImageBox.BorderStyle = BorderStyle.FixedSingle;
            IconImageBox.Location = new Point(593, 12);
            IconImageBox.Name = "IconImageBox";
            IconImageBox.Size = new Size(146, 146);
            IconImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            IconImageBox.TabIndex = 1;
            IconImageBox.TabStop = false;
            IconImageBox.Click += IconImageBox_Click;
            // 
            // IconLabel
            // 
            IconLabel.AutoSize = true;
            IconLabel.Location = new Point(503, 12);
            IconLabel.Name = "IconLabel";
            IconLabel.Size = new Size(30, 15);
            IconLabel.TabIndex = 11;
            IconLabel.Text = "Icon";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(619, 651);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(120, 23);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Image = Properties.Resources.item_icon;
            AddItemButton.Location = new Point(499, 565);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(40, 40);
            AddItemButton.TabIndex = 18;
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.MouseDown += AddItemButton_MouseDown;
            // 
            // AddBlockButton
            // 
            AddBlockButton.Image = Properties.Resources.block_icon;
            AddBlockButton.Location = new Point(539, 565);
            AddBlockButton.Name = "AddBlockButton";
            AddBlockButton.Size = new Size(40, 40);
            AddBlockButton.TabIndex = 19;
            AddBlockButton.UseVisualStyleBackColor = true;
            AddBlockButton.Click += AddBlockButton_Click;
            // 
            // AddEntityButton
            // 
            AddEntityButton.Image = Properties.Resources.entity_icon;
            AddEntityButton.Location = new Point(579, 565);
            AddEntityButton.Name = "AddEntityButton";
            AddEntityButton.Size = new Size(40, 40);
            AddEntityButton.TabIndex = 20;
            AddEntityButton.UseVisualStyleBackColor = true;
            AddEntityButton.Click += AddEntityButton_Click;
            // 
            // AddMiningButton
            // 
            AddMiningButton.Image = Properties.Resources.mining_icon;
            AddMiningButton.Location = new Point(619, 565);
            AddMiningButton.Name = "AddMiningButton";
            AddMiningButton.Size = new Size(40, 40);
            AddMiningButton.TabIndex = 21;
            AddMiningButton.UseVisualStyleBackColor = true;
            AddMiningButton.Click += AddMiningButton_Click;
            // 
            // AddSmithingButton
            // 
            AddSmithingButton.Image = Properties.Resources.smithing_icon;
            AddSmithingButton.Location = new Point(659, 565);
            AddSmithingButton.Name = "AddSmithingButton";
            AddSmithingButton.Size = new Size(40, 40);
            AddSmithingButton.TabIndex = 22;
            AddSmithingButton.UseVisualStyleBackColor = true;
            AddSmithingButton.Click += AddSmithingButton_Click;
            // 
            // AddBrewingButton
            // 
            AddBrewingButton.Image = Properties.Resources.brewing_icon;
            AddBrewingButton.Location = new Point(699, 565);
            AddBrewingButton.Name = "AddBrewingButton";
            AddBrewingButton.Size = new Size(40, 40);
            AddBrewingButton.TabIndex = 23;
            AddBrewingButton.UseVisualStyleBackColor = true;
            AddBrewingButton.Click += AddBrewingButton_Click;
            // 
            // BulkAddButton
            // 
            BulkAddButton.Location = new Point(499, 605);
            BulkAddButton.Name = "BulkAddButton";
            BulkAddButton.Size = new Size(120, 23);
            BulkAddButton.TabIndex = 24;
            BulkAddButton.Text = "Bulk add";
            BulkAddButton.UseVisualStyleBackColor = true;
            BulkAddButton.Click += BulkAddButton_Click;
            // 
            // TemplateButton
            // 
            TemplateButton.Location = new Point(619, 605);
            TemplateButton.Name = "TemplateButton";
            TemplateButton.Size = new Size(120, 23);
            TemplateButton.TabIndex = 25;
            TemplateButton.Text = "Template";
            TemplateButton.UseVisualStyleBackColor = true;
            TemplateButton.Click += TemplateButton_Click;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(499, 543);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(240, 23);
            ConvertButton.TabIndex = 17;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 697);
            Controls.Add(BulkAddButton);
            Controls.Add(TemplateButton);
            Controls.Add(AddBrewingButton);
            Controls.Add(AddSmithingButton);
            Controls.Add(AddMiningButton);
            Controls.Add(AddEntityButton);
            Controls.Add(AddBlockButton);
            Controls.Add(AddItemButton);
            Controls.Add(ClearButton);
            Controls.Add(IconLabel);
            Controls.Add(IconImageBox);
            Controls.Add(VersionTextBox);
            Controls.Add(VersionLabel);
            Controls.Add(ConvertButton);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(AddOnIdTextBox);
            Controls.Add(AddOnIdLabel);
            Controls.Add(AuthorTextBox);
            Controls.Add(AuthorLabel);
            Controls.Add(ObjectTypeLabel);
            Controls.Add(AddOnNameTextBox);
            Controls.Add(AddOnNameLabel);
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
            ((System.ComponentModel.ISupportInitialize)IconImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModKeyLabel;
        private Panel ItemPanel;
        private Label NameLabel;
        private Label SkillLabel;
        private Label LevelLabel;
        private TextBox NameTextBox;
        private ComboBox SkillsComboBox;
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
        private TextBox AddOnNameTextBox;
        private Label AddOnNameLabel;
        private TextBox AuthorTextBox;
        private Label AuthorLabel;
        private TextBox AddOnIdTextBox;
        private Label AddOnIdLabel;
        private Label DescriptionLabel;
        private RichTextBox DescriptionRichTextBox;
        private TextBox VersionTextBox;
        private Label VersionLabel;
        private PictureBox IconImageBox;
        private Label IconLabel;
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
    }
}
