
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Item : HasId
    {
        // <summary>
        // a resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return $"Item Id={ Id } ";
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
            var other = (Item)obj;
            return (
                 this.Id == other.Id
            );
        }

    }
}
