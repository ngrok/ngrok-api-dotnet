
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointSaml
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
        // The full XML IdP EntityDescriptor. Your IdP may provide this to you as a a file
        // to download or as a URL.
        // </summary>
        [JsonProperty("idp_metadata")]
        public string IdpMetadata { get; set; }
        // <summary>
        // If true, indicates that whenever we redirect a user to the IdP for
        // authentication that the IdP must prompt the user for authentication credentials
        // even if the user already has a valid session with the IdP.
        // </summary>
        [JsonProperty("force_authn")]
        public bool ForceAuthn { get; set; }
        // <summary>
        // If true, the IdP may initiate a login directly (e.g. the user does not need to
        // visit the endpoint first and then be redirected). The IdP should set the
        // <c>RelayState</c> parameter to the target URL of the resource they want the user
        // to be redirected to after the SAML login assertion has been processed.
        // </summary>
        [JsonProperty("allow_idp_initiated")]
        public bool? AllowIdpInitiated { get; set; }
        // <summary>
        // If present, only users who are a member of one of the listed groups may access
        // the target endpoint.
        // </summary>
        [JsonProperty("authorized_groups")]
        public List<string> AuthorizedGroups { get; set; }
        // <summary>
        // The SP Entity's unique ID. This always takes the form of a URL. In ngrok's
        // implementation, this URL is the same as the metadata URL. This will need to be
        // specified to the IdP as configuration.
        // </summary>
        [JsonProperty("entity_id")]
        public string EntityId { get; set; }
        // <summary>
        // The public URL of the SP's Assertion Consumer Service. This is where the IdP
        // will redirect to during an authentication flow. This will need to be specified
        // to the IdP as configuration.
        // </summary>
        [JsonProperty("assertion_consumer_service_url")]
        public string AssertionConsumerServiceUrl { get; set; }
        // <summary>
        // The public URL of the SP's Single Logout Service. This is where the IdP will
        // redirect to during a single logout flow. This will optionally need to be
        // specified to the IdP as configuration.
        // </summary>
        [JsonProperty("single_logout_url")]
        public string SingleLogoutUrl { get; set; }
        // <summary>
        // PEM-encoded x.509 certificate of the key pair that is used to sign all SAML
        // requests that the ngrok SP makes to the IdP. Many IdPs do not support request
        // signing verification, but we highly recommend specifying this in the IdP's
        // configuration if it is supported.
        // </summary>
        [JsonProperty("request_signing_certificate_pem")]
        public string RequestSigningCertificatePem { get; set; }
        // <summary>
        // A public URL where the SP's metadata is hosted. If an IdP supports dynamic
        // configuration, this is the URL it can use to retrieve the SP metadata.
        // </summary>
        [JsonProperty("metadata_url")]
        public string MetadataUrl { get; set; }
        // <summary>
        // Defines the name identifier format the SP expects the IdP to use in its
        // assertions to identify subjects. If unspecified, a default value of
        // <c>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</c> will be used. A
        // subset of the allowed values enumerated by the SAML specification are supported.
        // </summary>
        [JsonProperty("nameid_format")]
        public string NameidFormat { get; set; }

        public override string ToString()
        {
            return $"EndpointSaml Enabled={ Enabled }  OptionsPassthrough={ OptionsPassthrough }  CookiePrefix={ CookiePrefix }  InactivityTimeout={ InactivityTimeout }  MaximumDuration={ MaximumDuration }  IdpMetadata={ IdpMetadata }  ForceAuthn={ ForceAuthn }  AllowIdpInitiated={ AllowIdpInitiated }  AuthorizedGroups={ AuthorizedGroups }  EntityId={ EntityId }  AssertionConsumerServiceUrl={ AssertionConsumerServiceUrl }  SingleLogoutUrl={ SingleLogoutUrl }  RequestSigningCertificatePem={ RequestSigningCertificatePem }  MetadataUrl={ MetadataUrl }  NameidFormat={ NameidFormat } ";
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

                hash = hash * 23 + (EntityId?.GetHashCode() ?? 0);

                hash = hash * 23 + (AssertionConsumerServiceUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (SingleLogoutUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (RequestSigningCertificatePem?.GetHashCode() ?? 0);

                hash = hash * 23 + (MetadataUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (NameidFormat?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointSaml)obj;
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
                && this.EntityId == other.EntityId
                && this.AssertionConsumerServiceUrl == other.AssertionConsumerServiceUrl
                && this.SingleLogoutUrl == other.SingleLogoutUrl
                && this.RequestSigningCertificatePem == other.RequestSigningCertificatePem
                && this.MetadataUrl == other.MetadataUrl
                && this.NameidFormat == other.NameidFormat
            );
        }

    }
}
