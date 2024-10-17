using LevelZHelper.Models;
using LevelZHelper.Views;

namespace LevelZHelper.Controls
{
    public partial class MetadataControl : UserControl
    {
        private MetadataForm _metadataForm;
        private AddOnMetadata _metadata;

        private AddOnMetadata Metadata
        {
            get
            {
                return _metadata;
            }
            set
            {
                _metadata = value;
                OnMetadataSubmitted.Invoke(this, _metadata);
            }
        }

        public MetadataControl()
        {
            InitializeComponent();
            OnMetadataSubmitted += (o, m) => UpdateMetadataValues(m);
        }

        internal delegate void MetadataSubmitted(MetadataControl sender, AddOnMetadata metadata);

        internal event MetadataSubmitted OnMetadataSubmitted;

        internal void UpdateMetadata(AddOnMetadata metaData)
            => Metadata = metaData;

        private void UpdateMetadataValues(AddOnMetadata metaData)
        {
            IconImage.Image = metaData.Icon ?? IconImage.ErrorImage;
            ModIdValue.Text = metaData.Id;
            ModNameValue.Text = metaData.Name;
            AuthorValue.Text = metaData.Author;
            VersionValue.Text = metaData.Version;
            DescriptionValue.Text = metaData.Description;
        }

        private void MetadataControl_Load(object sender, EventArgs e)
        {
            IconImage.Image = IconImage.ErrorImage;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _metadataForm = new MetadataForm();
            _metadataForm.OnMetadataSubmitted += (o, m) =>
            {
                UpdateMetadata(m);
                _metadataForm.Close();
            };
            _metadataForm.Configure(_metadata);
            _metadataForm.Show();
        }

        private void ModIdValue_Click(object sender, EventArgs e)
        {

        }
    }
}
