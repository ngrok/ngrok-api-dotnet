using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class CredentialList
    {
        // <summary>
        // the list of all tunnel credentials on this account
        // </summary>
        [JsonPropertyName("credentials")]
        public List<Credential> Credentials { get; set; }
        // <summary>
        // URI of the tunnel credential list API resource
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
            return $"CredentialList Credentials={ Credentials }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Credentials?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (CredentialList)obj;
            return (
                 this.Credentials == other.Credentials
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
