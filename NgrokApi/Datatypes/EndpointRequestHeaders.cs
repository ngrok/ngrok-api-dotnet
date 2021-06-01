
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointRequestHeaders
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // a map of header key to header value that will be injected into the HTTP Request
        // before being sent to the upstream application server
        // </summary>
        [JsonProperty("add")]
        public Dictionary<string, string> Add { get; set; }
        // <summary>
        // a list of header names that will be removed from the HTTP Request before being
        // sent to the upstream application server
        // </summary>
        [JsonProperty("remove")]
        public List<string> Remove { get; set; }

        public override string ToString()
        {
            return $"EndpointRequestHeaders Enabled={ Enabled }  Add={ Add }  Remove={ Remove } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (Add?.GetHashCode() ?? 0);

                hash = hash * 23 + (Remove?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointRequestHeaders)obj;
            return (
                 this.Enabled == other.Enabled
                && this.Add == other.Add
                && this.Remove == other.Remove
            );
        }

    }
}
