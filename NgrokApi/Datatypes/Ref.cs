/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Ref : HasId
    {
        // <summary>
        // a resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // a uri for locating a resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        public override string ToString()
        {
            return $"Ref Id={ Id }  Uri={ Uri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (Ref)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
            );
        }

    }
}
