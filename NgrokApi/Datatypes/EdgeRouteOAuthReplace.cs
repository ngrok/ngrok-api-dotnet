
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EdgeRouteOAuthReplace : HasId
    {
        [JsonProperty("edge_id")]
        public string EdgeId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("module")]
        public EndpointOAuth Module { get; set; }

        public override string ToString()
        {
            return $"EdgeRouteOAuthReplace EdgeId={ EdgeId }  Id={ Id }  Module={ Module } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EdgeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Module?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EdgeRouteOAuthReplace)obj;
            return (
                 this.EdgeId == other.EdgeId
                && this.Id == other.Id
                && this.Module == other.Module
            );
        }

    }
}
