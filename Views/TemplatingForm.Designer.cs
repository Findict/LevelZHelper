using LevelZHelper.Models.Enums;
using LevelZHelper.Properties;

namespace LevelZHelper.Views
{
    partial class TemplatingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitButton = new Button();
            NameLabel = new Label();
            SkillLabel = new Label();
            NameTextBox = new TextBox();
            LevelLabel = new Label();
            LevelNumericSelector = new NumericUpDown();
            SkillsComboBox = new ComboBox();
            ModKeyTextBox = new TextBox();
            ModKeyLabel = new Label();
            PreviewRichTextBox = new RichTextBox();
            MaterialLabel = new Label();
            MaterialTextBox = new TextBox();
            TemplateComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).BeginInit();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(231, 186);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 73);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 15);
            NameLabel.TabIndex = 12;
            NameLabel.Text = "Item name";
            // 
            // SkillLabel
            // 
            SkillLabel.AutoSize = true;
            SkillLabel.Location = new Point(12, 102);
            SkillLabel.Name = "SkillLabel";
            SkillLabel.Size = new Size(28, 15);
            SkillLabel.TabIndex = 13;
            SkillLabel.Text = "Skill";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(102, 70);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(204, 23);
            NameTextBox.TabIndex = 9;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(12, 130);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 14;
            LevelLabel.Text = "Level";
            // 
            // LevelNumericSelector
            // 
            LevelNumericSelector.Location = new Point(102, 128);
            LevelNumericSelector.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            LevelNumericSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.Name = "LevelNumericSelector";
            LevelNumericSelector.Size = new Size(204, 23);
            LevelNumericSelector.TabIndex = 11;
            LevelNumericSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.ValueChanged += LevelNumericSelector_ValueChanged;
            // 
            // SkillsComboBox
            // 
            SkillsComboBox.FormattingEnabled = true;
            SkillsComboBox.Location = new Point(102, 99);
            SkillsComboBox.Name = "SkillsComboBox";
            SkillsComboBox.Size = new Size(204, 23);
            SkillsComboBox.TabIndex = 10;
            SkillsComboBox.SelectedIndexChanged += SkillsComboBox_SelectedIndexChanged;
            // 
            // ModKeyTextBox
            // 
            ModKeyTextBox.Location = new Point(102, 41);
            ModKeyTextBox.Name = "ModKeyTextBox";
            ModKeyTextBox.Size = new Size(204, 23);
            ModKeyTextBox.TabIndex = 15;
            ModKeyTextBox.TextChanged += ModKeyTextBox_TextChanged;
            // 
            // ModKeyLabel
            // 
            ModKeyLabel.AutoSize = true;
            ModKeyLabel.Location = new Point(12, 44);
            ModKeyLabel.Name = "ModKeyLabel";
            ModKeyLabel.Size = new Size(53, 15);
            ModKeyLabel.TabIndex = 16;
            ModKeyLabel.Text = "Mod key";
            // 
            // PreviewRichTextBox
            // 
            PreviewRichTextBox.DetectUrls = false;
            PreviewRichTextBox.Font = new Font("Consolas", 9F);
            PreviewRichTextBox.Location = new Point(12, 215);
            PreviewRichTextBox.Name = "PreviewRichTextBox";
            PreviewRichTextBox.Size = new Size(294, 197);
            PreviewRichTextBox.TabIndex = 17;
            PreviewRichTextBox.Text = "";
            PreviewRichTextBox.WordWrap = false;
            // 
            // MaterialLabel
            // 
            MaterialLabel.AutoSize = true;
            MaterialLabel.Location = new Point(12, 160);
            MaterialLabel.Name = "MaterialLabel";
            MaterialLabel.Size = new Size(50, 15);
            MaterialLabel.TabIndex = 19;
            MaterialLabel.Text = "Material";
            // 
            // MaterialTextBox
            // 
            MaterialTextBox.Location = new Point(102, 157);
            MaterialTextBox.Name = "MaterialTextBox";
            MaterialTextBox.Size = new Size(204, 23);
            MaterialTextBox.TabIndex = 18;
            MaterialTextBox.TextChanged += MaterialTextBox_TextChanged;
            // 
            // TemplateComboBox
            // 
            TemplateComboBox.DataSource = new TemplateType[]
    {
    TemplateType.Armor,
    TemplateType.MaterialToolSet
    };
            TemplateComboBox.FormattingEnabled = true;
            TemplateComboBox.Location = new Point(12, 12);
            TemplateComboBox.Name = "TemplateComboBox";
            TemplateComboBox.Size = new Size(294, 23);
            TemplateComboBox.TabIndex = 1;
            TemplateComboBox.SelectedIndexChanged += TemplateComboBox_SelectedIndexChanged;
            // 
            // TemplatingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 427);
            Controls.Add(TemplateComboBox);
            Controls.Add(MaterialLabel);
            Controls.Add(MaterialTextBox);
            Controls.Add(PreviewRichTextBox);
            Controls.Add(ModKeyTextBox);
            Controls.Add(ModKeyLabel);
            Controls.Add(NameLabel);
            Controls.Add(SkillLabel);
            Controls.Add(NameTextBox);
            Controls.Add(LevelLabel);
            Controls.Add(LevelNumericSelector);
            Controls.Add(SkillsComboBox);
            Controls.Add(SubmitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "TemplatingForm";
            Text = "Template";
            Load += TemplatingForm_Load;
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Label NameLabel;
        private Label SkillLabel;
        private TextBox NameTextBox;
        private Label LevelLabel;
        private NumericUpDown LevelNumericSelector;
        private ComboBox SkillsComboBox;
        private TextBox ModKeyTextBox;
        private Label ModKeyLabel;
        private RichTextBox PreviewRichTextBox;
        private Label MaterialLabel;
        private TextBox MaterialTextBox;
        private ComboBox TemplateComboBox;
    }
}