
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TunnelSessionsUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return $"TunnelSessionsUpdate Id={ Id } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TunnelSessionsUpdate)obj;
            return (
                 this.Id == other.Id
            );
        }

    }
}
