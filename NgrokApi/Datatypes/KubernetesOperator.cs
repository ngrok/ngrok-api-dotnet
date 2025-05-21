/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperator : HasId
    {
        // <summary>
        // unique identifier for this Kubernetes Operator
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of this Kubernetes Operator API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // timestamp when the Kubernetes Operator was created. RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // timestamp when the Kubernetes Operator was last updated. RFC 3339 format
        // </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
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
        // the principal who created this Kubernetes Operator
        // </summary>
        [JsonProperty("principal")]
        public Ref Principal { get; set; }
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
        // information about the Bindings feature of this Kubernetes Operator, if enabled
        // </summary>
        [JsonProperty("binding")]
        public KubernetesOperatorBinding Binding { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperator Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  UpdatedAt={ UpdatedAt }  Description={ Description }  Metadata={ Metadata }  Principal={ Principal }  EnabledFeatures={ EnabledFeatures }  Region={ Region }  Deployment={ Deployment }  Binding={ Binding } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (UpdatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Principal?.GetHashCode() ?? 0);

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
            var other = (KubernetesOperator)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.UpdatedAt == other.UpdatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Principal == other.Principal
                && this.EnabledFeatures == other.EnabledFeatures
                && this.Region == other.Region
                && this.Deployment == other.Deployment
                && this.Binding == other.Binding
            );
        }

    }
}
