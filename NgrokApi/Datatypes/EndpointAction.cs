/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointAction
    {
        // <summary>
        // the type of action on the policy rule.
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        // <summary>
        // the configuration for the action on the policy rule.
        // </summary>
        [JsonProperty("config")]
        public object Config { get; set; }

        public override string ToString()
        {
            return $"EndpointAction Type={ Type }  Config={ Config } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (Config?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointAction)obj;
            return (
                 this.Type == other.Type
                && this.Config == other.Config
            );
        }

    }
}
