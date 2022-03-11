using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshUserCertificateList
    {
        // <summary>
        // the list of all ssh user certificates on this account
        // </summary>
        [JsonPropertyName("ssh_user_certificates")]
        public List<SshUserCertificate> SshUserCertificates { get; set; }
        // <summary>
        // URI of the ssh user certificates list API resource
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
            return $"SshUserCertificateList SshUserCertificates={ SshUserCertificates }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshUserCertificates?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshUserCertificateList)obj;
            return (
                 this.SshUserCertificates == other.SshUserCertificates
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
