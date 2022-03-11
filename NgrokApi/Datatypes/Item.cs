using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class Item : HasId
    {
        // <summary>
        // a resource identifier
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return $"Item Id={ Id } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (Item)obj;
            return (
                 this.Id == other.Id
            );
        }

    }
}
