namespace LevelZHelper.Controls
{
    partial class MetadataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ModIdLabel = new Label();
            ModNameLabel = new Label();
            AuthorLabel = new Label();
            DescriptionLabel = new Label();
            ModIdValue = new Label();
            ModNameValue = new Label();
            AuthorValue = new Label();
            DescriptionValue = new Label();
            VersionValue = new Label();
            VersionLabel = new Label();
            IconImage = new PictureBox();
            EditButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // ModIdLabel
            // 
            ModIdLabel.AutoSize = true;
            ModIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ModIdLabel.Location = new Point(53, 203);
            ModIdLabel.Name = "ModIdLabel";
            ModIdLabel.Size = new Size(21, 15);
            ModIdLabel.TabIndex = 0;
            ModIdLabel.Text = "Id:";
            ModIdLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ModNameLabel
            // 
            ModNameLabel.AutoSize = true;
            ModNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ModNameLabel.Location = new Point(31, 218);
            ModNameLabel.Name = "ModNameLabel";
            ModNameLabel.Size = new Size(43, 15);
            ModNameLabel.TabIndex = 1;
            ModNameLabel.Text = "Name:";
            ModNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AuthorLabel.Location = new Point(25, 248);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(49, 15);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author:";
            AuthorLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DescriptionLabel.Location = new Point(0, 263);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(74, 15);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ModIdValue
            // 
            ModIdValue.Location = new Point(80, 203);
            ModIdValue.Name = "ModIdValue";
            ModIdValue.Size = new Size(197, 15);
            ModIdValue.TabIndex = 4;
            ModIdValue.Click += ModIdValue_Click;
            // 
            // ModNameValue
            // 
            ModNameValue.Location = new Point(80, 218);
            ModNameValue.Name = "ModNameValue";
            ModNameValue.Size = new Size(197, 15);
            ModNameValue.TabIndex = 5;
            // 
            // AuthorValue
            // 
            AuthorValue.Location = new Point(80, 248);
            AuthorValue.Name = "AuthorValue";
            AuthorValue.Size = new Size(197, 15);
            AuthorValue.TabIndex = 6;
            // 
            // DescriptionValue
            // 
            DescriptionValue.Location = new Point(80, 263);
            DescriptionValue.Name = "DescriptionValue";
            DescriptionValue.Size = new Size(197, 60);
            DescriptionValue.TabIndex = 7;
            // 
            // VersionValue
            // 
            VersionValue.Location = new Point(80, 233);
            VersionValue.Name = "VersionValue";
            VersionValue.Size = new Size(197, 15);
            VersionValue.TabIndex = 9;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VersionLabel.Location = new Point(23, 233);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(51, 15);
            VersionLabel.TabIndex = 8;
            VersionLabel.Text = "Version:";
            VersionLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // IconImage
            // 
            IconImage.BackColor = SystemColors.Control;
            IconImage.ErrorImage = Properties.Resources.no_img;
            IconImage.Image = Properties.Resources.no_img;
            IconImage.InitialImage = Properties.Resources.no_img;
            IconImage.Location = new Point(80, 3);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(197, 197);
            IconImage.SizeMode = PictureBoxSizeMode.StretchImage;
            IconImage.TabIndex = 10;
            IconImage.TabStop = false;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.Control;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            EditButton.IconColor = Color.Black;
            EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditButton.Location = new Point(6, 135);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(65, 65);
            EditButton.TabIndex = 11;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // MetadataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditButton);
            Controls.Add(IconImage);
            Controls.Add(VersionValue);
            Controls.Add(VersionLabel);
            Controls.Add(DescriptionValue);
            Controls.Add(AuthorValue);
            Controls.Add(ModNameValue);
            Controls.Add(ModIdValue);
            Controls.Add(DescriptionLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(ModNameLabel);
            Controls.Add(ModIdLabel);
            Name = "MetadataControl";
            Size = new Size(280, 323);
            Load += MetadataControl_Load;
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModIdLabel;
        private Label ModNameLabel;
        private Label AuthorLabel;
        private Label DescriptionLabel;
        private Label ModIdValue;
        private Label ModNameValue;
        private Label AuthorValue;
        private Label DescriptionValue;
        private Label VersionValue;
        private Label VersionLabel;
        private PictureBox IconImage;
        private FontAwesome.Sharp.IconButton EditButton;
    }
}
