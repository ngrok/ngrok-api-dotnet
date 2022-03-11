using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshCertificateAuthorityList
    {
        // <summary>
        // the list of all certificate authorities on this account
        // </summary>
        [JsonPropertyName("ssh_certificate_authorities")]
        public List<SshCertificateAuthority> SshCertificateAuthorities { get; set; }
        // <summary>
        // URI of the certificates authorities list API resource
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
            return $"SshCertificateAuthorityList SshCertificateAuthorities={ SshCertificateAuthorities }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshCertificateAuthorities?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshCertificateAuthorityList)obj;
            return (
                 this.SshCertificateAuthorities == other.SshCertificateAuthorities
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
