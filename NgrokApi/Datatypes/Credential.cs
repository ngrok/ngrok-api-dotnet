
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Credential : HasId
    {
        // <summary>
        // unique tunnel credential resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the tunnel credential API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the tunnel credential was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of who or what will use the credential to
        // authenticate. Optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this credential. Optional, max
        // 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // the credential's authtoken that can be used to authenticate an ngrok agent.
        // <strong>This value is only available one time, on the API response from
        // credential creation, otherwise it is null.</strong>
        // </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        // <summary>
        // optional list of ACL rules. If unspecified, the credential will have no
        // restrictions. The only allowed ACL rule at this time is the <c>bind</c> rule.
        // The <c>bind</c> rule allows the caller to restrict what domains and addresses
        // the token is allowed to bind. For example, to allow the token to open a tunnel
        // on example.ngrok.io your ACL would include the rule
        // <c>bind:example.ngrok.io</c>. Bind rules may specify a leading wildcard to match
        // multiple domains with a common suffix. For example, you may specify a rule of
        // <c>bind:*.example.com</c> which will allow <c>x.example.com</c>,
        // <c>y.example.com</c>, <c>*.example.com</c>, etc. A rule of <c>'*'</c> is
        // equivalent to no acl at all and will explicitly permit all actions.
        // </summary>
        [JsonProperty("acl")]
        public List<string> Acl { get; set; }

        public override string ToString()
        {
            return $"Credential Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Token={ Token }  Acl={ Acl } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Token?.GetHashCode() ?? 0);

                hash = hash * 23 + (Acl?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (Credential)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Token == other.Token
                && this.Acl == other.Acl
            );
        }

    }
}
