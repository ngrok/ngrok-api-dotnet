using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class ApiKeyList
    {
        // <summary>
        // the list of API keys for this account
        // </summary>
        [JsonPropertyName("keys")]
        public List<ApiKey> Keys { get; set; }
        // <summary>
        // URI of the API keys list API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonPropertyName("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"ApiKeyList Keys={ Keys }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Keys?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ApiKeyList)obj;
            return (
                 this.Keys == other.Keys
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
