using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class Ref : HasId
    {
        // <summary>
        // a resource identifier
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // a uri for locating a resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        public override string ToString()
        {
            return $"Ref Id={ Id }  Uri={ Uri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (Ref)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
            );
        }

    }
}
