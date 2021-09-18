
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointWebhookValidation
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // a string indicating which webhook provider will be sending webhooks to this
        // endpoint. Value must be one of the supported providers: <c>SLACK</c>,
        // <c>SNS</c>, <c>STRIPE</c>, <c>GITHUB</c>, <c>TWILIO</c>, <c>SHOPIFY</c>,
        // <c>GITLAB</c>, <c>INTERCOM</c>, <c>SENDGRID</c>.
        // </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }
        // <summary>
        // a string secret used to validate requests from the given provider. All providers
        // except AWS SNS require a secret
        // </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        public override string ToString()
        {
            return $"EndpointWebhookValidation Enabled={ Enabled }  Provider={ Provider }  Secret={ Secret } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (Provider?.GetHashCode() ?? 0);

                hash = hash * 23 + (Secret?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointWebhookValidation)obj;
            return (
                 this.Enabled == other.Enabled
                && this.Provider == other.Provider
                && this.Secret == other.Secret
            );
        }

    }
}
