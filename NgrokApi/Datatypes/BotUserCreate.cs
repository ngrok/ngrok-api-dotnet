/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class BotUserCreate
    {
        // <summary>
        // human-readable name used to identify the bot
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // whether or not the bot is active
        // </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        public override string ToString()
        {
            return $"BotUserCreate Name={ Name }  Active={ Active } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Active);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (BotUserCreate)obj;
            return (
                 this.Name == other.Name
                && this.Active == other.Active
            );
        }

    }
}
