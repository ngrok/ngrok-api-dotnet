/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class FilteredPaging
    {
        [JsonProperty("before_id")]
        public string BeforeId { get; set; }
        [JsonProperty("limit")]
        public string Limit { get; set; }
        [JsonProperty("filter")]
        public string Filter { get; set; }

        public override string ToString()
        {
            return $"FilteredPaging BeforeId={ BeforeId }  Limit={ Limit }  Filter={ Filter } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BeforeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Limit?.GetHashCode() ?? 0);

                hash = hash * 23 + (Filter?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (FilteredPaging)obj;
            return (
                 this.BeforeId == other.BeforeId
                && this.Limit == other.Limit
                && this.Filter == other.Filter
            );
        }

    }
}
