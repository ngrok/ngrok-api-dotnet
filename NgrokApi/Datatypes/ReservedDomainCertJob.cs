
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainCertJob
    {
        // <summary>
        // if present, an error code indicating why provisioning is failing. It may be
        // either a temporary condition (INTERNAL_ERROR), or a permanent one the user must
        // correct (DNS_ERROR).
        // </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
        // <summary>
        // a message describing the current status or error
        // </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
        // <summary>
        // timestamp when the provisioning job started, RFC 3339 format
        // </summary>
        [JsonProperty("started_at")]
        public string StartedAt { get; set; }
        // <summary>
        // timestamp when the provisioning job will be retried
        // </summary>
        [JsonProperty("retries_at")]
        public string RetriesAt { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainCertJob ErrorCode={ ErrorCode }  Msg={ Msg }  StartedAt={ StartedAt }  RetriesAt={ RetriesAt } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ErrorCode?.GetHashCode() ?? 0);

                hash = hash * 23 + (Msg?.GetHashCode() ?? 0);

                hash = hash * 23 + (StartedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (RetriesAt?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedDomainCertJob)obj;
            return (
                 this.ErrorCode == other.ErrorCode
                && this.Msg == other.Msg
                && this.StartedAt == other.StartedAt
                && this.RetriesAt == other.RetriesAt
            );
        }

    }
}
