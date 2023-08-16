/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ApplicationSession : HasId
    {
        // <summary>
        // unique application session resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the application session API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // URL of the hostport served by this endpoint
        // </summary>
        [JsonProperty("public_url")]
        public Uri PublicUrl { get; set; }
        // <summary>
        // browser session details of the application session
        // </summary>
        [JsonProperty("browser_session")]
        public BrowserSession BrowserSession { get; set; }
        // <summary>
        // application user this session is associated with
        // </summary>
        [JsonProperty("application_user")]
        public Ref ApplicationUser { get; set; }
        // <summary>
        // timestamp when the user was created in RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // timestamp when the user was last active in RFC 3339 format
        // </summary>
        [JsonProperty("last_active")]
        public string LastActive { get; set; }
        // <summary>
        // timestamp when session expires in RFC 3339 format
        // </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }
        // <summary>
        // ephemeral endpoint this session is associated with
        // </summary>
        [JsonProperty("endpoint")]
        public Ref Endpoint { get; set; }
        // <summary>
        // edge this session is associated with, null if the endpoint is agent-initiated
        // </summary>
        [JsonProperty("edge")]
        public Ref Edge { get; set; }
        // <summary>
        // route this session is associated with, null if the endpoint is agent-initiated
        // </summary>
        [JsonProperty("route")]
        public Ref Route { get; set; }

        public override string ToString()
        {
            return $"ApplicationSession Id={ Id }  Uri={ Uri }  PublicUrl={ PublicUrl }  BrowserSession={ BrowserSession }  ApplicationUser={ ApplicationUser }  CreatedAt={ CreatedAt }  LastActive={ LastActive }  ExpiresAt={ ExpiresAt }  Endpoint={ Endpoint }  Edge={ Edge }  Route={ Route } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (PublicUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (BrowserSession?.GetHashCode() ?? 0);

                hash = hash * 23 + (ApplicationUser?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (LastActive?.GetHashCode() ?? 0);

                hash = hash * 23 + (ExpiresAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Endpoint?.GetHashCode() ?? 0);

                hash = hash * 23 + (Edge?.GetHashCode() ?? 0);

                hash = hash * 23 + (Route?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ApplicationSession)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.PublicUrl == other.PublicUrl
                && this.BrowserSession == other.BrowserSession
                && this.ApplicationUser == other.ApplicationUser
                && this.CreatedAt == other.CreatedAt
                && this.LastActive == other.LastActive
                && this.ExpiresAt == other.ExpiresAt
                && this.Endpoint == other.Endpoint
                && this.Edge == other.Edge
                && this.Route == other.Route
            );
        }

    }
}
