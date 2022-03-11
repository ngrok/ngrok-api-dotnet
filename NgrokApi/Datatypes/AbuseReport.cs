using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class AbuseReport : HasId
    {
        // <summary>
        // ID of the abuse report
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the abuse report API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp that the abuse report record was created in RFC 3339 format
        // </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // a list of URLs containing suspected abusive content
        // </summary>
        [JsonPropertyName("urls")]
        public List<string> Urls { get; set; }
        // <summary>
        // arbitrary user-defined data about this abuse report. Optional, max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Indicates whether ngrok has processed the abuse report. one of <c>PENDING</c>,
        // <c>PROCESSED</c>, or <c>PARTIALLY_PROCESSED</c>
        // </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
        // <summary>
        // an array of hostname statuses related to the report
        // </summary>
        [JsonPropertyName("hostnames")]
        public List<AbuseReportHostname> Hostnames { get; set; }

        public override string ToString()
        {
            return $"AbuseReport Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Urls={ Urls }  Metadata={ Metadata }  Status={ Status }  Hostnames={ Hostnames } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Urls?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Status?.GetHashCode() ?? 0);

                hash = hash * 23 + (Hostnames?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AbuseReport)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Urls == other.Urls
                && this.Metadata == other.Metadata
                && this.Status == other.Status
                && this.Hostnames == other.Hostnames
            );
        }

    }
}
