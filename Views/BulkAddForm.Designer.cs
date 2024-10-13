namespace LevelZHelper.Views
{
    partial class BulkAddForm
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
            InputRichTextBox = new RichTextBox();
            SkillLabel = new Label();
            LevelLabel = new Label();
            LevelNumericSelector = new NumericUpDown();
            SkillsComboBox = new ComboBox();
            SubmitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).BeginInit();
            SuspendLayout();
            // 
            // InputRichTextBox
            // 
            InputRichTextBox.DetectUrls = false;
            InputRichTextBox.Font = new Font("Consolas", 9F);
            InputRichTextBox.Location = new Point(12, 64);
            InputRichTextBox.Name = "InputRichTextBox";
            InputRichTextBox.Size = new Size(517, 372);
            InputRichTextBox.TabIndex = 30;
            InputRichTextBox.Text = "";
            InputRichTextBox.WordWrap = false;
            // 
            // SkillLabel
            // 
            SkillLabel.AutoSize = true;
            SkillLabel.Location = new Point(12, 9);
            SkillLabel.Name = "SkillLabel";
            SkillLabel.Size = new Size(28, 15);
            SkillLabel.TabIndex = 26;
            SkillLabel.Text = "Skill";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(12, 37);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(34, 15);
            LevelLabel.TabIndex = 27;
            LevelLabel.Text = "Level";
            // 
            // LevelNumericSelector
            // 
            LevelNumericSelector.Location = new Point(102, 35);
            LevelNumericSelector.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            LevelNumericSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LevelNumericSelector.Name = "LevelNumericSelector";
            LevelNumericSelector.Size = new Size(427, 23);
            LevelNumericSelector.TabIndex = 24;
            LevelNumericSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SkillsComboBox
            // 
            SkillsComboBox.FormattingEnabled = true;
            SkillsComboBox.Location = new Point(102, 6);
            SkillsComboBox.Name = "SkillsComboBox";
            SkillsComboBox.Size = new Size(427, 23);
            SkillsComboBox.TabIndex = 23;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(454, 442);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 20;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // BulkAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 477);
            Controls.Add(InputRichTextBox);
            Controls.Add(SkillLabel);
            Controls.Add(LevelLabel);
            Controls.Add(LevelNumericSelector);
            Controls.Add(SkillsComboBox);
            Controls.Add(SubmitButton);
            Name = "BulkAddForm";
            Text = "Bulk add";
            Load += this.BulkAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)LevelNumericSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox InputRichTextBox;
        private Label SkillLabel;
        private Label LevelLabel;
        private NumericUpDown LevelNumericSelector;
        private ComboBox SkillsComboBox;
        private Button SubmitButton;
    }
}