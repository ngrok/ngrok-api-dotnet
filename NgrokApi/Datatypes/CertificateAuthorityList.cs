using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class CertificateAuthorityList
    {
        // <summary>
        // the list of all certificate authorities on this account
        // </summary>
        [JsonPropertyName("certificate_authorities")]
        public List<CertificateAuthority> CertificateAuthorities { get; set; }
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
            return $"CertificateAuthorityList CertificateAuthorities={ CertificateAuthorities }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (CertificateAuthorities?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (CertificateAuthorityList)obj;
            return (
                 this.CertificateAuthorities == other.CertificateAuthorities
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
