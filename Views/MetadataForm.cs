using LevelZHelper.Models;

namespace LevelZHelper.Views
{
    public partial class MetadataForm : Form
    {
        public MetadataForm()
        {
            InitializeComponent();
        }

        internal delegate void SubmitMetadata(MetadataForm sender, AddOnMetadata items);

        internal event SubmitMetadata? OnMetadataSubmitted;

        private void IconImageBox_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            dialog.Filter = "Images|*.png";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                ImportIcon(dialog.FileName);
            }
        }

        private void ImportIcon(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var iconFile = File.OpenRead(filePath);

            IconImageBox.Image = Image.FromStream(iconFile);

            iconFile.Close();
        }

        internal void Configure(AddOnMetadata metadata)
        {
            if (metadata == null) return;

            IconImageBox.Image = metadata.Icon;
            AddOnIdTextBox.Text = metadata.Id;
            AddOnNameTextBox.Text = metadata.Name;
            VersionTextBox.Text = metadata.Version;
            AuthorTextBox.Text = metadata.Author;
            DescriptionRichTextBox.Text = metadata.Description;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (OnMetadataSubmitted == null) return;

            var metadata = new AddOnMetadata();

            metadata.SetIcon(IconImageBox.Image);
            metadata.SetValues(AddOnIdTextBox.Text, AddOnNameTextBox.Text, VersionTextBox.Text, AuthorTextBox.Text, DescriptionRichTextBox.Text);

            OnMetadataSubmitted.Invoke(this, metadata);
        }
    }
}
