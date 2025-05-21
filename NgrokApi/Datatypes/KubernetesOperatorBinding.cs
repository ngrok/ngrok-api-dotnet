/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorBinding
    {
        // <summary>
        // the list of cel expressions that filter the k8s bound endpoints for this
        // operator
        // </summary>
        [JsonProperty("endpoint_selectors")]
        public List<string> EndpointSelectors { get; set; }
        // <summary>
        // the binding certificate information
        // </summary>
        [JsonProperty("cert")]
        public KubernetesOperatorCert Cert { get; set; }
        // <summary>
        // the public ingress endpoint for this Kubernetes Operator
        // </summary>
        [JsonProperty("ingress_endpoint")]
        public string IngressEndpoint { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorBinding EndpointSelectors={ EndpointSelectors }  Cert={ Cert }  IngressEndpoint={ IngressEndpoint } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EndpointSelectors?.GetHashCode() ?? 0);

                hash = hash * 23 + (Cert?.GetHashCode() ?? 0);

                hash = hash * 23 + (IngressEndpoint?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (KubernetesOperatorBinding)obj;
            return (
                 this.EndpointSelectors == other.EndpointSelectors
                && this.Cert == other.Cert
                && this.IngressEndpoint == other.IngressEndpoint
            );
        }

    }
}
