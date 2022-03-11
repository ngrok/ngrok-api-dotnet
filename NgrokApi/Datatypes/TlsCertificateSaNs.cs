using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class TlsCertificateSaNs
    {
        // <summary>
        // set of additional domains (including wildcards) this TLS certificate is valid
        // for
        // </summary>
        [JsonPropertyName("dns_names")]
        public List<string> DnsNames { get; set; }
        // <summary>
        // set of IP addresses this TLS certificate is also valid for
        // </summary>
        [JsonPropertyName("ips")]
        public List<string> Ips { get; set; }

        public override string ToString()
        {
            return $"TlsCertificateSaNs DnsNames={ DnsNames }  Ips={ Ips } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (DnsNames?.GetHashCode() ?? 0);

                hash = hash * 23 + (Ips?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (TlsCertificateSaNs)obj;
            return (
                 this.DnsNames == other.DnsNames
                && this.Ips == other.Ips
            );
        }

    }
}
