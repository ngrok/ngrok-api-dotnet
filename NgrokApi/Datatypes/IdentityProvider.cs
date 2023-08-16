/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class IdentityProvider
    {
        // <summary>
        // name of the identity provider (e.g. Google)
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // URL of the identity provider (e.g. <see
        // href="https://accounts.google.com">https://accounts.google.com</see>)
        // </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return $"IdentityProvider Name={ Name }  Url={ Url } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + (Url?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (IdentityProvider)obj;
            return (
                 this.Name == other.Name
                && this.Url == other.Url
            );
        }

    }
}
