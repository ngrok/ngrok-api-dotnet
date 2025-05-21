/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorCert
    {
        // <summary>
        // the public client certificate generated for this Kubernetes Operator from the
        // CSR supplied when enabling the Bindings feature
        // </summary>
        [JsonProperty("cert")]
        public string Cert { get; set; }
        // <summary>
        // timestamp when the certificate becomes valid. RFC 3339 format
        // </summary>
        [JsonProperty("not_before")]
        public string NotBefore { get; set; }
        // <summary>
        // timestamp when the certificate becomes invalid. RFC 3339 format
        // </summary>
        [JsonProperty("not_after")]
        public string NotAfter { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorCert Cert={ Cert }  NotBefore={ NotBefore }  NotAfter={ NotAfter } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Cert?.GetHashCode() ?? 0);

                hash = hash * 23 + (NotBefore?.GetHashCode() ?? 0);

                hash = hash * 23 + (NotAfter?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (KubernetesOperatorCert)obj;
            return (
                 this.Cert == other.Cert
                && this.NotBefore == other.NotBefore
                && this.NotAfter == other.NotAfter
            );
        }

    }
}
