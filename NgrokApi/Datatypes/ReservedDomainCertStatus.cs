using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class ReservedDomainCertStatus
    {
        // <summary>
        // timestamp when the next renewal will be requested, RFC 3339 format
        // </summary>
        [JsonPropertyName("renews_at")]
        public string RenewsAt { get; set; }
        // <summary>
        // status of the certificate provisioning job, or null if the certificiate isn't
        // being provisioned or renewed
        // </summary>
        [JsonPropertyName("provisioning_job")]
        public ReservedDomainCertJob ProvisioningJob { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainCertStatus RenewsAt={ RenewsAt }  ProvisioningJob={ ProvisioningJob } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (RenewsAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (ProvisioningJob?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedDomainCertStatus)obj;
            return (
                 this.RenewsAt == other.RenewsAt
                && this.ProvisioningJob == other.ProvisioningJob
            );
        }

    }
}
