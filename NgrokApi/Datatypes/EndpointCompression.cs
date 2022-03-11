
using System;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointCompression
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        public override string ToString()
        {
            return $"EndpointCompression Enabled={ Enabled } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointCompression)obj;
            return (
                 this.Enabled == other.Enabled
            );
        }

    }
}
