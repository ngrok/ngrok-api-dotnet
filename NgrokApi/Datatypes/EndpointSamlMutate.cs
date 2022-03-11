
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointSamlMutate
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // Do not enforce authentication on HTTP OPTIONS requests. necessary if you are
        // supporting CORS.
        // </summary>
        [JsonPropertyName("options_passthrough")]
        public bool OptionsPassthrough { get; set; }
        // <summary>
        // the prefix of the session cookie that ngrok sets on the http client to cache
        // authentication. default is 'ngrok.'
        // </summary>
        [JsonPropertyName("cookie_prefix")]
        public string CookiePrefix { get; set; }
        // <summary>
        // Integer number of seconds of inactivity after which if the user has not accessed
        // the endpoint, their session will time out and they will be forced to
        // reauthenticate.
        // </summary>
        [JsonPropertyName("inactivity_timeout")]
        public int InactivityTimeout { get; set; }
        // <summary>
        // Integer number of seconds of the maximum duration of an authenticated session.
        // After this period is exceeded, a user must reauthenticate.
        // </summary>
        [JsonPropertyName("maximum_duration")]
        public int MaximumDuration { get; set; }
        // <summary>
        // The full XML IdP EntityDescriptor. Your IdP may provide this to you as a a file
        // to download or as a URL.
        // </summary>
        [JsonPropertyName("idp_metadata")]
        public string IdpMetadata { get; set; }
        // <summary>
        // If true, indicates that whenever we redirect a user to the IdP for
        // authentication that the IdP must prompt the user for authentication credentials
        // even if the user already has a valid session with the IdP.
        // </summary>
        [JsonPropertyName("force_authn")]
        public bool ForceAuthn { get; set; }
        // <summary>
        // If true, the IdP may initiate a login directly (e.g. the user does not need to
        // visit the endpoint first and then be redirected). The IdP should set the
        // <c>RelayState</c> parameter to the target URL of the resource they want the user
        // to be redirected to after the SAML login assertion has been processed.
        // </summary>
        [JsonPropertyName("allow_idp_initiated")]
        public bool? AllowIdpInitiated { get; set; }
        // <summary>
        // If present, only users who are a member of one of the listed groups may access
        // the target endpoint.
        // </summary>
        [JsonPropertyName("authorized_groups")]
        public List<string> AuthorizedGroups { get; set; }
        // <summary>
        // Defines the name identifier format the SP expects the IdP to use in its
        // assertions to identify subjects. If unspecified, a default value of
        // <c>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</c> will be used. A
        // subset of the allowed values enumerated by the SAML specification are supported.
        // </summary>
        [JsonPropertyName("nameid_format")]
        public string NameidFormat { get; set; }

        public override string ToString()
        {
            return $"EndpointSamlMutate Enabled={ Enabled }  OptionsPassthrough={ OptionsPassthrough }  CookiePrefix={ CookiePrefix }  InactivityTimeout={ InactivityTimeout }  MaximumDuration={ MaximumDuration }  IdpMetadata={ IdpMetadata }  ForceAuthn={ ForceAuthn }  AllowIdpInitiated={ AllowIdpInitiated }  AuthorizedGroups={ AuthorizedGroups }  NameidFormat={ NameidFormat } ";
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
                hash = hash * 23 + (IdpMetadata?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(ForceAuthn);
                hash = hash * 23 + Convert.ToInt32(AllowIdpInitiated);
                hash = hash * 23 + (AuthorizedGroups?.GetHashCode() ?? 0);

                hash = hash * 23 + (NameidFormat?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointSamlMutate)obj;
            return (
                 this.Enabled == other.Enabled
                && this.OptionsPassthrough == other.OptionsPassthrough
                && this.CookiePrefix == other.CookiePrefix
                && this.InactivityTimeout == other.InactivityTimeout
                && this.MaximumDuration == other.MaximumDuration
                && this.IdpMetadata == other.IdpMetadata
                && this.ForceAuthn == other.ForceAuthn
                && this.AllowIdpInitiated == other.AllowIdpInitiated
                && this.AuthorizedGroups == other.AuthorizedGroups
                && this.NameidFormat == other.NameidFormat
            );
        }

    }
}
