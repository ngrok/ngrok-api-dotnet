
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshHostCertificateList
    {
        // <summary>
        // the list of all ssh host certificates on this account
        // </summary>
        [JsonProperty("ssh_host_certificates")]
        public List<SshHostCertificate> SshHostCertificates { get; set; }
        // <summary>
        // URI of the ssh host certificates list API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonProperty("next_page_uri")]
        public Uri NextPageUri { get; set; }

        public override string ToString()
        {
            return $"SshHostCertificateList SshHostCertificates={ SshHostCertificates }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshHostCertificates?.GetHashCode() ?? 0);

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
            var other = (SshHostCertificateList)obj;
            return (
                 this.SshHostCertificates == other.SshHostCertificates
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
