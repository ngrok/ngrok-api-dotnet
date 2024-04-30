/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class StaticBackendTls
    {
        // <summary>
        // if TLS is checked
        // </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        public override string ToString()
        {
            return $"StaticBackendTls Enabled={ Enabled } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (StaticBackendTls)obj;
            return (
                 this.Enabled == other.Enabled
            );
        }

    }
}
