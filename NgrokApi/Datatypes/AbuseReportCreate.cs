using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class AbuseReportCreate
    {
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

        public override string ToString()
        {
            return $"AbuseReportCreate Urls={ Urls }  Metadata={ Metadata } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Urls?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AbuseReportCreate)obj;
            return (
                 this.Urls == other.Urls
                && this.Metadata == other.Metadata
            );
        }

    }
}
