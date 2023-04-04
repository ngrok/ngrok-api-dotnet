
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ApplicationUser : HasId
    {
        // <summary>
        // unique application user resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the application user API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // identity provider that the user authenticated with
        // </summary>
        [JsonProperty("identity_provider")]
        public IdentityProvider IdentityProvider { get; set; }
        // <summary>
        // unique user identifier
        // </summary>
        [JsonProperty("provider_user_id")]
        public string ProviderUserId { get; set; }
        // <summary>
        // user username
        // </summary>
        [JsonProperty("username")]
        public string Username { get; set; }
        // <summary>
        // user email
        // </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        // <summary>
        // user common name
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
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
        // timestamp when the user last signed-in in RFC 3339 format
        // </summary>
        [JsonProperty("last_login")]
        public string LastLogin { get; set; }

        public override string ToString()
        {
            return $"ApplicationUser Id={ Id }  Uri={ Uri }  IdentityProvider={ IdentityProvider }  ProviderUserId={ ProviderUserId }  Username={ Username }  Email={ Email }  Name={ Name }  CreatedAt={ CreatedAt }  LastActive={ LastActive }  LastLogin={ LastLogin } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (IdentityProvider?.GetHashCode() ?? 0);

                hash = hash * 23 + (ProviderUserId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Username?.GetHashCode() ?? 0);

                hash = hash * 23 + (Email?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (LastActive?.GetHashCode() ?? 0);

                hash = hash * 23 + (LastLogin?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ApplicationUser)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.IdentityProvider == other.IdentityProvider
                && this.ProviderUserId == other.ProviderUserId
                && this.Username == other.Username
                && this.Email == other.Email
                && this.Name == other.Name
                && this.CreatedAt == other.CreatedAt
                && this.LastActive == other.LastActive
                && this.LastLogin == other.LastLogin
            );
        }

    }
}
