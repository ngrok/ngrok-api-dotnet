/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ServiceUser : HasId
    {
        // <summary>
        // unique API key resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI to the API resource of this service user
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // human-readable name used to identify the service
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // whether or not the service is active
        // </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }
        // <summary>
        // timestamp when the api key was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        public override string ToString()
        {
            return $"ServiceUser Id={ Id }  Uri={ Uri }  Name={ Name }  Active={ Active }  CreatedAt={ CreatedAt } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Active);
                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ServiceUser)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.Name == other.Name
                && this.Active == other.Active
                && this.CreatedAt == other.CreatedAt
            );
        }

    }
}
