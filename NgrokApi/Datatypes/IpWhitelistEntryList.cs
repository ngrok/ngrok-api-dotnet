
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class IpWhitelistEntryList
    {
        // <summary>
        // the list of all IP whitelist entries on this account
        // </summary>
        [JsonProperty("whitelist")]
        public List<IpWhitelistEntry> Whitelist { get; set; }
        // <summary>
        // URI of the IP whitelist API resource
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
            return $"IpWhitelistEntryList Whitelist={ Whitelist }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Whitelist?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpWhitelistEntryList)obj;
            return (
                 this.Whitelist == other.Whitelist
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
