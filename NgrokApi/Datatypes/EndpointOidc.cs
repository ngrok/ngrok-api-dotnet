/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointOidc
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // Do not enforce authentication on HTTP OPTIONS requests. necessary if you are
        // supporting CORS.
        // </summary>
        [JsonProperty("options_passthrough")]
        public bool OptionsPassthrough { get; set; }
        // <summary>
        // the prefix of the session cookie that ngrok sets on the http client to cache
        // authentication. default is 'ngrok.'
        // </summary>
        [JsonProperty("cookie_prefix")]
        public string CookiePrefix { get; set; }
        // <summary>
        // Integer number of seconds of inactivity after which if the user has not accessed
        // the endpoint, their session will time out and they will be forced to
        // reauthenticate.
        // </summary>
        [JsonProperty("inactivity_timeout")]
        public int InactivityTimeout { get; set; }
        // <summary>
        // Integer number of seconds of the maximum duration of an authenticated session.
        // After this period is exceeded, a user must reauthenticate.
        // </summary>
        [JsonProperty("maximum_duration")]
        public int MaximumDuration { get; set; }
        // <summary>
        // URL of the OIDC "OpenID provider". This is the base URL used for discovery.
        // </summary>
        [JsonProperty("issuer")]
        public string Issuer { get; set; }
        // <summary>
        // The OIDC app's client ID and OIDC audience.
        // </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        // <summary>
        // The OIDC app's client secret.
        // </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        // <summary>
        // The set of scopes to request from the OIDC identity provider.
        // </summary>
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }

        public override string ToString()
        {
            return $"EndpointOidc Enabled={ Enabled }  OptionsPassthrough={ OptionsPassthrough }  CookiePrefix={ CookiePrefix }  InactivityTimeout={ InactivityTimeout }  MaximumDuration={ MaximumDuration }  Issuer={ Issuer }  ClientId={ ClientId }  ClientSecret={ ClientSecret }  Scopes={ Scopes } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + Convert.ToInt32(OptionsPassthrough);
                hash = hash * 23 + (CookiePrefix?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(InactivityTimeout);
                hash = hash * 23 + Convert.ToInt32(MaximumDuration);
                hash = hash * 23 + (Issuer?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClientId?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClientSecret?.GetHashCode() ?? 0);

                hash = hash * 23 + (Scopes?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointOidc)obj;
            return (
                 this.Enabled == other.Enabled
                && this.OptionsPassthrough == other.OptionsPassthrough
                && this.CookiePrefix == other.CookiePrefix
                && this.InactivityTimeout == other.InactivityTimeout
                && this.MaximumDuration == other.MaximumDuration
                && this.Issuer == other.Issuer
                && this.ClientId == other.ClientId
                && this.ClientSecret == other.ClientSecret
                && this.Scopes == other.Scopes
            );
        }

    }
}
