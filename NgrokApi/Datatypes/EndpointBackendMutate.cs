
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointBackendMutate
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // backend to be used to back this endpoint
        // </summary>
        [JsonProperty("backend_id")]
        public string BackendId { get; set; }

        public override string ToString()
        {
            return $"EndpointBackendMutate Enabled={ Enabled }  BackendId={ BackendId } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (BackendId?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointBackendMutate)obj;
            return (
                 this.Enabled == other.Enabled
                && this.BackendId == other.BackendId
            );
        }

    }
}
