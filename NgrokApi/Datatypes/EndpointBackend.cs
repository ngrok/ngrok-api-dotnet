
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointBackend
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
        [JsonProperty("backend")]
        public Ref Backend { get; set; }

        public override string ToString()
        {
            return $"EndpointBackend Enabled={ Enabled }  Backend={ Backend } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (Backend?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointBackend)obj;
            return (
                 this.Enabled == other.Enabled
                && this.Backend == other.Backend
            );
        }

    }
}
