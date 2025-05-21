/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorCreate
    {
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
        // information about the deployment of this Kubernetes Operator
        // </summary>
        [JsonProperty("deployment")]
        public KubernetesOperatorDeployment Deployment { get; set; }
        // <summary>
        // configuration for the Bindings feature of this Kubernetes Operator. set only if
        // enabling the "bindings" feature
        // </summary>
        [JsonProperty("binding")]
        public KubernetesOperatorBindingCreate Binding { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorCreate Description={ Description }  Metadata={ Metadata }  EnabledFeatures={ EnabledFeatures }  Region={ Region }  Deployment={ Deployment }  Binding={ Binding } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (EnabledFeatures?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (Deployment?.GetHashCode() ?? 0);

                hash = hash * 23 + (Binding?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (KubernetesOperatorCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.EnabledFeatures == other.EnabledFeatures
                && this.Region == other.Region
                && this.Deployment == other.Deployment
                && this.Binding == other.Binding
            );
        }

    }
}
