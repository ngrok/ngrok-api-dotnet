
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointResponseHeadersReplace : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("module")]
        public EndpointResponseHeaders Module { get; set; }

        public override string ToString()
        {
            return $"EndpointResponseHeadersReplace Id={ Id }  Module={ Module } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Module?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointResponseHeadersReplace)obj;
            return (
                 this.Id == other.Id
                && this.Module == other.Module
            );
        }

    }
}
