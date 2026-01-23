/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainResolvesToEntry
    {
        // <summary>
        // accepts an ngrok point-of-presence shortcode, or "global"
        // </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainResolvesToEntry Value={ Value } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Value?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ReservedDomainResolvesToEntry)obj;
            return (
                 this.Value == other.Value
            );
        }

    }
}
