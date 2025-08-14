/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointListArgs
    {
        [JsonProperty("before_id")]
        public string BeforeId { get; set; }
        [JsonProperty("limit")]
        public string Limit { get; set; }
        [JsonProperty("ids")]
        public List<string> Ids { get; set; }
        [JsonProperty("urls")]
        public List<string> Urls { get; set; }

        public override string ToString()
        {
            return $"EndpointListArgs BeforeId={ BeforeId }  Limit={ Limit }  Ids={ Ids }  Urls={ Urls } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BeforeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Limit?.GetHashCode() ?? 0);

                hash = hash * 23 + (Ids?.GetHashCode() ?? 0);

                hash = hash * 23 + (Urls?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointListArgs)obj;
            return (
                 this.BeforeId == other.BeforeId
                && this.Limit == other.Limit
                && this.Ids == other.Ids
                && this.Urls == other.Urls
            );
        }

    }
}
