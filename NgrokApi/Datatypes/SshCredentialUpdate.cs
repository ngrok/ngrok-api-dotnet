using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshCredentialUpdate : HasId
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // human-readable description of who or what will use the ssh credential to
        // authenticate. Optional, max 255 bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this ssh credential. Optional,
        // max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
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
        [JsonPropertyName("acl")]
        public List<string> Acl { get; set; }

        public override string ToString()
        {
            return $"SshCredentialUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  Acl={ Acl } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Acl?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshCredentialUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Acl == other.Acl
            );
        }

    }
}
