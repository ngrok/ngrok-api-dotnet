/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class BrowserSession
    {
        // <summary>
        // HTTP User-Agent data
        // </summary>
        [JsonProperty("user_agent")]
        public UserAgent UserAgent { get; set; }
        // <summary>
        // IP address
        // </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }
        // <summary>
        // IP geolocation data
        // </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }

        public override string ToString()
        {
            return $"BrowserSession UserAgent={ UserAgent }  IpAddress={ IpAddress }  Location={ Location } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (UserAgent?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpAddress?.GetHashCode() ?? 0);

                hash = hash * 23 + (Location?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (BrowserSession)obj;
            return (
                 this.UserAgent == other.UserAgent
                && this.IpAddress == other.IpAddress
                && this.Location == other.Location
            );
        }

    }
}
