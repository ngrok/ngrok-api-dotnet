using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class ApiKeyUpdate : HasId
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // human-readable description of what uses the API key to authenticate. optional,
        // max 255 bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined data of this API key. optional, max 4096 bytes
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }

        public override string ToString()
        {
            return $"ApiKeyUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ApiKeyUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
            );
        }

    }
}
