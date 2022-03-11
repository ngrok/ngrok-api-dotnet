using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshCredentialList
    {
        // <summary>
        // the list of all ssh credentials on this account
        // </summary>
        [JsonPropertyName("ssh_credentials")]
        public List<SshCredential> SshCredentials { get; set; }
        // <summary>
        // URI of the ssh credential list API resource
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
            return $"SshCredentialList SshCredentials={ SshCredentials }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshCredentials?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshCredentialList)obj;
            return (
                 this.SshCredentials == other.SshCredentials
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
