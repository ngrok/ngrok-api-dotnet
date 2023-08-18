/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ApiKey : HasId
    {
        // <summary>
        // unique API key resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI to the API resource of this API key
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // human-readable description of what uses the API key to authenticate. optional,
        // max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined data of this API key. optional, max 4096 bytes
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // timestamp when the api key was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // the bearer token that can be placed into the Authorization header to
        // authenticate request to the ngrok API. <strong>This value is only available one
        // time, on the API response from key creation. Otherwise it is null.</strong>
        // </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        // <summary>
        // If supplied at credential creation, ownership will be assigned to the specified
        // User or Bot. Only admins may specify an owner other than themselves. Defaults to
        // the authenticated User or Bot.
        // </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        public override string ToString()
        {
            return $"ApiKey Id={ Id }  Uri={ Uri }  Description={ Description }  Metadata={ Metadata }  CreatedAt={ CreatedAt }  Token={ Token }  OwnerId={ OwnerId } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Token?.GetHashCode() ?? 0);

                hash = hash * 23 + (OwnerId?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ApiKey)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CreatedAt == other.CreatedAt
                && this.Token == other.Token
                && this.OwnerId == other.OwnerId
            );
        }

    }
}
