using System.Text.Json.Serialization;

namespace LevelZHelper.Models.AuxFiles
{
    internal class FabricModFile
    {
        public FabricModFile() { }

        public FabricModFile(AddOnMetadata metaData)
        {
            SchemaVersion = 1;
            Id = metaData.Id;
            Version = metaData.Version;
            Name = metaData.Name;
            Description = metaData.Description;
            Authors = [metaData.Author];
            License = "MIT";
            Icon = "icon.png";
            Environment = "*";
            Depends = new Dictionary<string, string>
            {
                { "fabric-resource-loader-v0", "*" }
            };
        }

        [JsonPropertyName("schemaVersion")]
        public int? SchemaVersion { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("authors")]
        public string?[]? Authors { get; set; }

        [JsonPropertyName("license")]
        public string? License { get; set; }

        [JsonPropertyName("icon")]
        public string? Icon { get; set; }

        [JsonPropertyName("environment")]
        public string? Environment { get; set; }

        [JsonPropertyName("depends")]
        public Dictionary<string, string>? Depends { get; set; }
    }
}
