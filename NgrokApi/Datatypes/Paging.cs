using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class Paging
    {
        [JsonPropertyName("before_id")]
        public string BeforeId { get; set; }
        [JsonPropertyName("limit")]
        public string Limit { get; set; }

        public override string ToString()
        {
            return $"Paging BeforeId={ BeforeId }  Limit={ Limit } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BeforeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Limit?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (Paging)obj;
            return (
                 this.BeforeId == other.BeforeId
                && this.Limit == other.Limit
            );
        }

    }
}
