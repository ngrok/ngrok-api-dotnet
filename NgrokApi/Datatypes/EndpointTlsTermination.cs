
using System;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointTlsTermination
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // <c>edge</c> if the ngrok edge should terminate TLS traffic, <c>upstream</c> if
        // TLS traffic should be passed through to the upstream ngrok agent / application
        // server for termination. if <c>upstream</c> is chosen, most other modules will be
        // disallowed because they rely on the ngrok edge being able to access the
        // underlying traffic.
        // </summary>
        [JsonPropertyName("terminate_at")]
        public string TerminateAt { get; set; }
        // <summary>
        // The minimum TLS version used for termination and advertised to the client during
        // the TLS handshake. if unspecified, ngrok will choose an industry-safe default.
        // This value must be null if <c>terminate_at</c> is set to <c>upstream</c>.
        // </summary>
        [JsonPropertyName("min_version")]
        public string MinVersion { get; set; }

        public override string ToString()
        {
            return $"EndpointTlsTermination Enabled={ Enabled }  TerminateAt={ TerminateAt }  MinVersion={ MinVersion } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (TerminateAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (MinVersion?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointTlsTermination)obj;
            return (
                 this.Enabled == other.Enabled
                && this.TerminateAt == other.TerminateAt
                && this.MinVersion == other.MinVersion
            );
        }

    }
}
