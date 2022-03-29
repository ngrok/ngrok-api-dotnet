
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedAddrCreate
    {
        // <summary>
        // human-readable description of what this reserved address will be used for
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this reserved address. Optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // reserve the address in this geographic ngrok datacenter. Optional, default is
        // us. (au, eu, ap, us, jp, in, sa)
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        public override string ToString()
        {
            return $"ReservedAddrCreate Description={ Description }  Metadata={ Metadata }  Region={ Region } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ReservedAddrCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Region == other.Region
            );
        }

    }
}
