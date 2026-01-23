/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class FilteredPaging
    {
        // <summary>
        // Expects a resource ID as its input. Returns earlier entries in the result set,
        // sorted by ID.
        // </summary>
        [JsonProperty("before_id")]
        public string BeforeId { get; set; }
        // <summary>
        // Constrains the number of results in the dataset. See the <see
        // href="https://ngrok.com/docs/api/index#pagination">API Overview</see> for
        // details.
        // </summary>
        [JsonProperty("limit")]
        public string Limit { get; set; }
        // <summary>
        // A CEL expression to filter the list results. Supports logical and comparison
        // operators to match on fields such as <c>id</c>, <c>metadata</c>,
        // <c>created_at</c>, and more. See ngrok API Filtering for syntax and field
        // details: <see
        // href="https://ngrok.com/docs/api/api-filtering">https://ngrok.com/docs/api/api-filtering</see>.
        // </summary>
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
