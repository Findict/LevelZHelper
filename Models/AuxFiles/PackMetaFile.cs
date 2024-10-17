using System.Text.Json.Serialization;

namespace LevelZHelper.Models.AuxFiles
{
    internal class PackMetaFile
    {
        public PackMetaFile(AddOnMetadata metaData)
        {
            Pack = new PackFile(15, metaData.Description);
        }

        [JsonPropertyName("pack")]
        public PackFile Pack { get; set; }
    }

    internal class PackFile
    {
        public PackFile(int format, string? description)
        {
            PackFormat = format;
            Description = description;
        }

        [JsonPropertyName("pack_format")]
        public int PackFormat { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
