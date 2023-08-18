/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointOAuthAmazon
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        [JsonProperty("email_addresses")]
        public List<string> EmailAddresses { get; set; }
        [JsonProperty("email_domains")]
        public List<string> EmailDomains { get; set; }

        public override string ToString()
        {
            return $"EndpointOAuthAmazon ClientId={ ClientId }  ClientSecret={ ClientSecret }  Scopes={ Scopes }  EmailAddresses={ EmailAddresses }  EmailDomains={ EmailDomains } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ClientId?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClientSecret?.GetHashCode() ?? 0);

                hash = hash * 23 + (Scopes?.GetHashCode() ?? 0);

                hash = hash * 23 + (EmailAddresses?.GetHashCode() ?? 0);

                hash = hash * 23 + (EmailDomains?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointOAuthAmazon)obj;
            return (
                 this.ClientId == other.ClientId
                && this.ClientSecret == other.ClientSecret
                && this.Scopes == other.Scopes
                && this.EmailAddresses == other.EmailAddresses
                && this.EmailDomains == other.EmailDomains
            );
        }

    }
}
