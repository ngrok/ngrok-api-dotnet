
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointOAuth
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // an object which defines the identity provider to use for authentication and
        // configuration for who may access the endpoint
        // </summary>
        [JsonProperty("provider")]
        public EndpointOAuthProvider Provider { get; set; }
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
        // Integer number of seconds after which ngrok guarantees it will refresh user
        // state from the identity provider and recheck whether the user is still
        // authorized to access the endpoint. This is the preferred tunable to use to
        // enforce a minimum amount of time after which a revoked user will no longer be
        // able to access the resource.
        // </summary>
        [JsonProperty("auth_check_interval")]
        public int AuthCheckInterval { get; set; }

        public override string ToString()
        {
            return $"EndpointOAuth Enabled={ Enabled }  Provider={ Provider }  OptionsPassthrough={ OptionsPassthrough }  CookiePrefix={ CookiePrefix }  InactivityTimeout={ InactivityTimeout }  MaximumDuration={ MaximumDuration }  AuthCheckInterval={ AuthCheckInterval } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (Provider?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(OptionsPassthrough);
                hash = hash * 23 + (CookiePrefix?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(InactivityTimeout);
                hash = hash * 23 + Convert.ToInt32(MaximumDuration);
                hash = hash * 23 + Convert.ToInt32(AuthCheckInterval);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointOAuth)obj;
            return (
                 this.Enabled == other.Enabled
                && this.Provider == other.Provider
                && this.OptionsPassthrough == other.OptionsPassthrough
                && this.CookiePrefix == other.CookiePrefix
                && this.InactivityTimeout == other.InactivityTimeout
                && this.MaximumDuration == other.MaximumDuration
                && this.AuthCheckInterval == other.AuthCheckInterval
            );
        }

    }
}
