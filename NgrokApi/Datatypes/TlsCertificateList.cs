
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TlsCertificateList
    {
        // <summary>
        // the list of all TLS certificates on this account
        // </summary>
        [JsonProperty("tls_certificates")]
        public List<TlsCertificate> TlsCertificates { get; set; }
        // <summary>
        // URI of the TLS certificates list API resource
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
            return $"TlsCertificateList TlsCertificates={ TlsCertificates }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (TlsCertificates?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (TlsCertificateList)obj;
            return (
                 this.TlsCertificates == other.TlsCertificates
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
