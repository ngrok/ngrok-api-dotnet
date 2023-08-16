/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TlsCertificateSaNs
    {
        // <summary>
        // set of additional domains (including wildcards) this TLS certificate is valid
        // for
        // </summary>
        [JsonProperty("dns_names")]
        public List<string> DnsNames { get; set; }
        // <summary>
        // set of IP addresses this TLS certificate is also valid for
        // </summary>
        [JsonProperty("ips")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TlsCertificateSaNs)obj;
            return (
                 this.DnsNames == other.DnsNames
                && this.Ips == other.Ips
            );
        }

    }
}
