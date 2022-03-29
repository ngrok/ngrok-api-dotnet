
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshCredentialList
    {
        // <summary>
        // the list of all ssh credentials on this account
        // </summary>
        [JsonProperty("ssh_credentials")]
        public List<SshCredential> SshCredentials { get; set; }
        // <summary>
        // URI of the ssh credential list API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonProperty("next_page_uri")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (SshCredentialList)obj;
            return (
                 this.SshCredentials == other.SshCredentials
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
