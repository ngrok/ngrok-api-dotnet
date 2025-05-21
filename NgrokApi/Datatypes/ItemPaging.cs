/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ItemPaging : HasId
    {
        // <summary>
        // a resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("before_id")]
        public string BeforeId { get; set; }
        [JsonProperty("limit")]
        public string Limit { get; set; }

        public override string ToString()
        {
            return $"ItemPaging Id={ Id }  BeforeId={ BeforeId }  Limit={ Limit } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (BeforeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Limit?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ItemPaging)obj;
            return (
                 this.Id == other.Id
                && this.BeforeId == other.BeforeId
                && this.Limit == other.Limit
            );
        }

    }
}
