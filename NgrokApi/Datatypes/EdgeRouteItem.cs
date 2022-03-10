
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EdgeRouteItem : HasId
    {
        // <summary>
        // unique identifier of this edge
        // </summary>
        [JsonProperty("edge_id")]
        public string EdgeId { get; set; }
        // <summary>
        // unique identifier of this edge route
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return $"EdgeRouteItem EdgeId={ EdgeId }  Id={ Id } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EdgeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EdgeRouteItem)obj;
            return (
                 this.EdgeId == other.EdgeId
                && this.Id == other.Id
            );
        }

    }
}
