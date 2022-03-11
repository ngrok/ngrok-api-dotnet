
using System;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointCircuitBreaker
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // Integer number of seconds after which the circuit is tripped to wait before
        // re-evaluating upstream health
        // </summary>
        [JsonPropertyName("tripped_duration")]
        public int TrippedDuration { get; set; }
        // <summary>
        // Integer number of seconds in the statistical rolling window that metrics are
        // retained for.
        // </summary>
        [JsonPropertyName("rolling_window")]
        public int RollingWindow { get; set; }
        // <summary>
        // Integer number of buckets into which metrics are retained. Max 128.
        // </summary>
        [JsonPropertyName("num_buckets")]
        public int NumBuckets { get; set; }
        // <summary>
        // Integer number of requests in a rolling window that will trip the circuit.
        // Helpful if traffic volume is low.
        // </summary>
        [JsonPropertyName("volume_threshold")]
        public int VolumeThreshold { get; set; }
        // <summary>
        // Error threshold percentage should be between 0 - 1.0, not 0-100.0
        // </summary>
        [JsonPropertyName("error_threshold_percentage")]
        public double ErrorThresholdPercentage { get; set; }

        public override string ToString()
        {
            return $"EndpointCircuitBreaker Enabled={ Enabled }  TrippedDuration={ TrippedDuration }  RollingWindow={ RollingWindow }  NumBuckets={ NumBuckets }  VolumeThreshold={ VolumeThreshold }  ErrorThresholdPercentage={ ErrorThresholdPercentage } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + Convert.ToInt32(TrippedDuration);
                hash = hash * 23 + Convert.ToInt32(RollingWindow);
                hash = hash * 23 + Convert.ToInt32(NumBuckets);
                hash = hash * 23 + Convert.ToInt32(VolumeThreshold);
                hash = hash * 23 + Convert.ToInt32(ErrorThresholdPercentage);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointCircuitBreaker)obj;
            return (
                 this.Enabled == other.Enabled
                && this.TrippedDuration == other.TrippedDuration
                && this.RollingWindow == other.RollingWindow
                && this.NumBuckets == other.NumBuckets
                && this.VolumeThreshold == other.VolumeThreshold
                && this.ErrorThresholdPercentage == other.ErrorThresholdPercentage
            );
        }

    }
}
