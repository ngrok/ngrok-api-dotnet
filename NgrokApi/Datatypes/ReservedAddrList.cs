using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class ReservedAddrList
    {
        // <summary>
        // the list of all reserved addresses on this account
        // </summary>
        [JsonPropertyName("reserved_addrs")]
        public List<ReservedAddr> ReservedAddrs { get; set; }
        // <summary>
        // URI of the reserved address list API resource
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
            return $"ReservedAddrList ReservedAddrs={ ReservedAddrs }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ReservedAddrs?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedAddrList)obj;
            return (
                 this.ReservedAddrs == other.ReservedAddrs
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
