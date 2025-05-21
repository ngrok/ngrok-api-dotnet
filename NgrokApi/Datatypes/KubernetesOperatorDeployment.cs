/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorDeployment
    {
        // <summary>
        // the deployment name
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // the namespace this Kubernetes Operator is deployed to
        // </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
        // <summary>
        // the version of this Kubernetes Operator
        // </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
        // <summary>
        // user-given name for the cluster the Kubernetes Operator is deployed to
        // </summary>
        [JsonProperty("cluster_name")]
        public string ClusterName { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorDeployment Name={ Name }  Namespace={ Namespace }  Version={ Version }  ClusterName={ ClusterName } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + (Namespace?.GetHashCode() ?? 0);

                hash = hash * 23 + (Version?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClusterName?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (KubernetesOperatorDeployment)obj;
            return (
                 this.Name == other.Name
                && this.Namespace == other.Namespace
                && this.Version == other.Version
                && this.ClusterName == other.ClusterName
            );
        }

    }
}
