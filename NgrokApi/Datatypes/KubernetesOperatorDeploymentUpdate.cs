/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class KubernetesOperatorDeploymentUpdate
    {
        // <summary>
        // the deployment name
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // the version of this Kubernetes Operator
        // </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        public override string ToString()
        {
            return $"KubernetesOperatorDeploymentUpdate Name={ Name }  Version={ Version } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + (Version?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (KubernetesOperatorDeploymentUpdate)obj;
            return (
                 this.Name == other.Name
                && this.Version == other.Version
            );
        }

    }
}
