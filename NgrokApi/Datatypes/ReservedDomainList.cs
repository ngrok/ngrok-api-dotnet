
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainList
    {
        // <summary>
        // the list of all reserved domains on this account
        // </summary>
        [JsonProperty("reserved_domains")]
        public List<ReservedDomain> ReservedDomains { get; set; }
        // <summary>
        // URI of the reserved domain list API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonProperty("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainList ReservedDomains={ ReservedDomains }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ReservedDomains?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedDomainList)obj;
            return (
                 this.ReservedDomains == other.ReservedDomains
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
