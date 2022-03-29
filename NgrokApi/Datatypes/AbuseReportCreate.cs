
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AbuseReportCreate
    {
        // <summary>
        // a list of URLs containing suspected abusive content
        // </summary>
        [JsonProperty("urls")]
        public List<string> Urls { get; set; }
        // <summary>
        // arbitrary user-defined data about this abuse report. Optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (AbuseReportCreate)obj;
            return (
                 this.Urls == other.Urls
                && this.Metadata == other.Metadata
            );
        }

    }
}
