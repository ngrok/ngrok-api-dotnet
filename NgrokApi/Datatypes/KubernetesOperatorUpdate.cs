/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorUpdate : HasId
    {
        // <summary>
        // unique identifier for this Kubernetes Operator
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // human-readable description of this Kubernetes Operator. optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this Kubernetes Operator.
        // optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // features enabled for this Kubernetes Operator. a subset of "bindings",
        // "ingress", and "gateway"
        // </summary>
        [JsonProperty("enabled_features")]
        public List<string> EnabledFeatures { get; set; }
        // <summary>
        // the ngrok region in which the ingress for this operator is served. defaults to
        // "global"
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
        // <summary>
        // configuration for the Bindings feature of this Kubernetes Operator. set only if
        // enabling the "bindings" feature
        // </summary>
        [JsonProperty("binding")]
        public KubernetesOperatorBindingUpdate Binding { get; set; }
        // <summary>
        // configuration for the Deployment info
        // </summary>
        [JsonProperty("deployment")]
        public KubernetesOperatorDeploymentUpdate Deployment { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  EnabledFeatures={ EnabledFeatures }  Region={ Region }  Binding={ Binding }  Deployment={ Deployment } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (EnabledFeatures?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (Binding?.GetHashCode() ?? 0);

                hash = hash * 23 + (Deployment?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (KubernetesOperatorUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.EnabledFeatures == other.EnabledFeatures
                && this.Region == other.Region
                && this.Binding == other.Binding
                && this.Deployment == other.Deployment
            );
        }

    }
}
