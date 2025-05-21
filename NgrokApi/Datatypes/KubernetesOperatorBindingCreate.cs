/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorBindingCreate
    {
        // <summary>
        // the list of cel expressions that filter the k8s bound endpoints for this
        // operator
        // </summary>
        [JsonProperty("endpoint_selectors")]
        public List<string> EndpointSelectors { get; set; }
        // <summary>
        // CSR is supplied during initial creation to enable creating a mutual TLS secured
        // connection between ngrok and the operator. This is an internal implementation
        // detail and subject to change.
        // </summary>
        [JsonProperty("csr")]
        public string Csr { get; set; }
        // <summary>
        // the public ingress endpoint for this Kubernetes Operator
        // </summary>
        [JsonProperty("ingress_endpoint")]
        public string IngressEndpoint { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorBindingCreate EndpointSelectors={ EndpointSelectors }  Csr={ Csr }  IngressEndpoint={ IngressEndpoint } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EndpointSelectors?.GetHashCode() ?? 0);

                hash = hash * 23 + (Csr?.GetHashCode() ?? 0);

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
            var other = (KubernetesOperatorBindingCreate)obj;
            return (
                 this.EndpointSelectors == other.EndpointSelectors
                && this.Csr == other.Csr
                && this.IngressEndpoint == other.IngressEndpoint
            );
        }

    }
}
