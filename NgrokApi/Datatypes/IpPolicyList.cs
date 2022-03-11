using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class IpPolicyList
    {
        // <summary>
        // the list of all IP policies on this account
        // </summary>
        [JsonPropertyName("ip_policies")]
        public List<IpPolicy> IpPolicies { get; set; }
        // <summary>
        // URI of the IP policy list API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonPropertyName("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"IpPolicyList IpPolicies={ IpPolicies }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (IpPolicies?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpPolicyList)obj;
            return (
                 this.IpPolicies == other.IpPolicies
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
