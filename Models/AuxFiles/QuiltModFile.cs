using System.Text.Json.Serialization;

namespace LevelZHelper.Models.AuxFiles
{
    internal class QuiltModFile
    {
        public QuiltModFile(AddOnMetaData metaData)
        {
            SchemaVersion = 1;
            QuiltLoader = new QuiltLoader(metaData);
        }

        [JsonPropertyName("schema_version")]
        public int SchemaVersion { get; set; }

        [JsonPropertyName("quilt_loader")]
        public QuiltLoader QuiltLoader { get; set; }
    }

    internal class QuiltLoader
    {
        public QuiltLoader(AddOnMetaData metaData)
        {
            Group = "com.modrinth";
            Id = metaData.Id;
            Version = metaData.Version;
            MetaData = new QuiltMetaData(metaData);
            IntermediateMappings = "net.fabricmc:intermediary";
            Depends = [new QuiltDependency()];
        }

        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("metadata")]
        public QuiltMetaData MetaData { get; set; }

        [JsonPropertyName("intermediate_mappings")]
        public string IntermediateMappings { get; set; }

        [JsonPropertyName("depends")]
        public QuiltDependency[] Depends { get; set; }
    }

    internal class QuiltMetaData
    {
        public QuiltMetaData(AddOnMetaData metaData)
        {
            Name = metaData.Name;
            Description = metaData.Description;
            if (!string.IsNullOrWhiteSpace(metaData.Author))
            {
                Contributors = new Dictionary<string, string>
                {
                    { metaData.Author, "Owner" }
                };
            }
            Icon = "icon.png";
        }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("contributors")]
        public Dictionary<string, string>? Contributors { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    internal class QuiltDependency
    {
        public QuiltDependency()
        {
            Id = "quilt_resource_loader";
            Versions = "*";
            Unless = "fabric-resource-loader-v0";
        }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("versions")]
        public string Versions { get; set; }

        [JsonPropertyName("unless")]
        public string Unless { get; set; }
    }
}
