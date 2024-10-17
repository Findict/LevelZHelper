namespace LevelZHelper.Views
{
    partial class MetadataForm
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
            IconLabel = new Label();
            IconImageBox = new PictureBox();
            VersionTextBox = new TextBox();
            VersionLabel = new Label();
            DescriptionRichTextBox = new RichTextBox();
            DescriptionLabel = new Label();
            AddOnIdTextBox = new TextBox();
            AddOnIdLabel = new Label();
            AuthorTextBox = new TextBox();
            AuthorLabel = new Label();
            AddOnNameTextBox = new TextBox();
            AddOnNameLabel = new Label();
            SubmitButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)IconImageBox).BeginInit();
            SuspendLayout();
            // 
            // IconLabel
            // 
            IconLabel.AutoSize = true;
            IconLabel.Location = new Point(16, 14);
            IconLabel.Name = "IconLabel";
            IconLabel.Size = new Size(30, 15);
            IconLabel.TabIndex = 24;
            IconLabel.Text = "Icon";
            // 
            // IconImageBox
            // 
            IconImageBox.BackColor = SystemColors.Window;
            IconImageBox.BorderStyle = BorderStyle.FixedSingle;
            IconImageBox.Location = new Point(106, 14);
            IconImageBox.Name = "IconImageBox";
            IconImageBox.Size = new Size(146, 146);
            IconImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            IconImageBox.TabIndex = 18;
            IconImageBox.TabStop = false;
            IconImageBox.Click += IconImageBox_Click;
            // 
            // VersionTextBox
            // 
            VersionTextBox.Location = new Point(106, 224);
            VersionTextBox.Name = "VersionTextBox";
            VersionTextBox.Size = new Size(146, 23);
            VersionTextBox.TabIndex = 21;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(16, 227);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(45, 15);
            VersionLabel.TabIndex = 25;
            VersionLabel.Text = "Version";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(12, 303);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(240, 80);
            DescriptionRichTextBox.TabIndex = 23;
            DescriptionRichTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(16, 285);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 26;
            DescriptionLabel.Text = "Description";
            // 
            // AddOnIdTextBox
            // 
            AddOnIdTextBox.Location = new Point(106, 166);
            AddOnIdTextBox.Name = "AddOnIdTextBox";
            AddOnIdTextBox.Size = new Size(146, 23);
            AddOnIdTextBox.TabIndex = 19;
            // 
            // AddOnIdLabel
            // 
            AddOnIdLabel.AutoSize = true;
            AddOnIdLabel.Location = new Point(16, 169);
            AddOnIdLabel.Name = "AddOnIdLabel";
            AddOnIdLabel.Size = new Size(61, 15);
            AddOnIdLabel.TabIndex = 27;
            AddOnIdLabel.Text = "Add-on id";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(106, 253);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(146, 23);
            AuthorTextBox.TabIndex = 22;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(16, 256);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(44, 15);
            AuthorLabel.TabIndex = 28;
            AuthorLabel.Text = "Author";
            // 
            // AddOnNameTextBox
            // 
            AddOnNameTextBox.Location = new Point(106, 195);
            AddOnNameTextBox.Name = "AddOnNameTextBox";
            AddOnNameTextBox.Size = new Size(146, 23);
            AddOnNameTextBox.TabIndex = 20;
            // 
            // AddOnNameLabel
            // 
            AddOnNameLabel.AutoSize = true;
            AddOnNameLabel.Location = new Point(16, 198);
            AddOnNameLabel.Name = "AddOnNameLabel";
            AddOnNameLabel.Size = new Size(81, 15);
            AddOnNameLabel.TabIndex = 29;
            AddOnNameLabel.Text = "Add-on name";
            // 
            // iconButton1
            // 
            SubmitButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            SubmitButton.IconColor = Color.Black;
            SubmitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmitButton.IconSize = 24;
            SubmitButton.Location = new Point(220, 389);
            SubmitButton.Name = "iconButton1";
            SubmitButton.Padding = new Padding(0, 2, 0, 0);
            SubmitButton.Size = new Size(32, 32);
            SubmitButton.TabIndex = 30;
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // MetadataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 433);
            Controls.Add(SubmitButton);
            Controls.Add(IconLabel);
            Controls.Add(IconImageBox);
            Controls.Add(VersionTextBox);
            Controls.Add(VersionLabel);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(AddOnIdTextBox);
            Controls.Add(AddOnIdLabel);
            Controls.Add(AuthorTextBox);
            Controls.Add(AuthorLabel);
            Controls.Add(AddOnNameTextBox);
            Controls.Add(AddOnNameLabel);
            Name = "MetadataForm";
            Text = "MetadataForm";
            ((System.ComponentModel.ISupportInitialize)IconImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IconLabel;
        private PictureBox IconImageBox;
        private TextBox VersionTextBox;
        private Label VersionLabel;
        private RichTextBox DescriptionRichTextBox;
        private Label DescriptionLabel;
        private TextBox AddOnIdTextBox;
        private Label AddOnIdLabel;
        private TextBox AuthorTextBox;
        private Label AuthorLabel;
        private TextBox AddOnNameTextBox;
        private Label AddOnNameLabel;
        private FontAwesome.Sharp.IconButton SubmitButton;
    }
}