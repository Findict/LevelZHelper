using LevelZHelper.Models.AuxFiles;

namespace LevelZHelper.Models
{
    internal class AddOnMetaData
    {
        public AddOnMetaData() { }

        public void Update(FabricModFile modFile)
        {
            Id = modFile.Id;
            Name = modFile.Name;
            Author = modFile.Authors?.FirstOrDefault();
            Version = modFile.Version;
            Description = modFile.Description;
        }

        internal void Clear()
        {
            Id = null;
            Name = null;
            Author = null;
            Version = null;
            Description = null;
        }

        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Author { get; set; }

        public string? Version { get; set; }

        public string? Description { get; set; }
    }
}
