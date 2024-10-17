using LevelZHelper.Models.AuxFiles;

namespace LevelZHelper.Models
{
    internal class AddOnMetadata
    {
        public AddOnMetadata() { }

        public void Update(FabricModFile modFile)
        {
            Id = modFile.Id;
            Name = modFile.Name;
            Version = modFile.Version;
            Author = modFile.Authors?.FirstOrDefault();
            Description = modFile.Description;
        }

        internal void Clear()
        {
            Icon = null;
            Id = null;
            Name = null;
            Version = null;
            Author = null;
            Description = null;
        }

        internal void SetIcon(Image? icon)
            => Icon = icon;

        internal void SetValues(string id, string name, string version, string author, string description)
        {
            Id = id;
            Name = name;
            Version = version;
            Author = author;
            Description = description;
        }

        public Image? Icon { get; private set; }

        public string? Id { get; private set; }

        public string? Name { get; private set; }

        public string? Version { get; private set; }

        public string? Author { get; private set; }

        public string? Description { get; private set; }
    }
}
