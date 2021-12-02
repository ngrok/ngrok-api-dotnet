
namespace NgrokApi
{
    public class Ngrok
    {
        private IApiHttpClient apiHttpClient;

        public Ngrok(string apiKey, string apiBaseUrl = "https://api.ngrok.com")
        {
            apiHttpClient = new ApiHttpClient(apiKey, apiBaseUrl);
        }
        // for testing
        internal Ngrok(IApiHttpClient apiHttpClient)
        {
            this.apiHttpClient = apiHttpClient;
        }

        public AbuseReports AbuseReports
        {
            get { return new AbuseReports(apiHttpClient); }
        }

        public AgentIngresses AgentIngresses
        {
            get { return new AgentIngresses(apiHttpClient); }
        }

        public ApiKeys ApiKeys
        {
            get { return new ApiKeys(apiHttpClient); }
        }

        public CertificateAuthorities CertificateAuthorities
        {
            get { return new CertificateAuthorities(apiHttpClient); }
        }

        public Credentials Credentials
        {
            get { return new Credentials(apiHttpClient); }
        }

        public EndpointConfigurations EndpointConfigurations
        {
            get { return new EndpointConfigurations(apiHttpClient); }
        }

        public EventStreams EventStreams
        {
            get { return new EventStreams(apiHttpClient); }
        }

        public EventDestinations EventDestinations
        {
            get { return new EventDestinations(apiHttpClient); }
        }

        public EventSubscriptions EventSubscriptions
        {
            get { return new EventSubscriptions(apiHttpClient); }
        }

        public EventSources EventSources
        {
            get { return new EventSources(apiHttpClient); }
        }

        public IpPolicies IpPolicies
        {
            get { return new IpPolicies(apiHttpClient); }
        }

        public IpPolicyRules IpPolicyRules
        {
            get { return new IpPolicyRules(apiHttpClient); }
        }

        public IpRestrictions IpRestrictions
        {
            get { return new IpRestrictions(apiHttpClient); }
        }

        public ReservedAddrs ReservedAddrs
        {
            get { return new ReservedAddrs(apiHttpClient); }
        }

        public ReservedDomains ReservedDomains
        {
            get { return new ReservedDomains(apiHttpClient); }
        }

        public SshCertificateAuthorities SshCertificateAuthorities
        {
            get { return new SshCertificateAuthorities(apiHttpClient); }
        }

        public SshCredentials SshCredentials
        {
            get { return new SshCredentials(apiHttpClient); }
        }

        public SshHostCertificates SshHostCertificates
        {
            get { return new SshHostCertificates(apiHttpClient); }
        }

        public SshUserCertificates SshUserCertificates
        {
            get { return new SshUserCertificates(apiHttpClient); }
        }

        public TlsCertificates TlsCertificates
        {
            get { return new TlsCertificates(apiHttpClient); }
        }

        public TunnelSessions TunnelSessions
        {
            get { return new TunnelSessions(apiHttpClient); }
        }

        public Tunnels Tunnels
        {
            get { return new Tunnels(apiHttpClient); }
        }


        public PointcfgModuleNamespace PointcfgModule
        {
            get { return new PointcfgModuleNamespace(apiHttpClient); }
        }

    }
    public class PointcfgModuleNamespace
    {
        private IApiHttpClient apiHttpClient;
        public PointcfgModuleNamespace(IApiHttpClient apiHttpClient)
        {
            this.apiHttpClient = apiHttpClient;
        }

        public EndpointLoggingModule Logging
        {
            get { return new EndpointLoggingModule(apiHttpClient); }
        }

        public EndpointCircuitBreakerModule CircuitBreaker
        {
            get { return new EndpointCircuitBreakerModule(apiHttpClient); }
        }

        public EndpointCompressionModule Compression
        {
            get { return new EndpointCompressionModule(apiHttpClient); }
        }

        public EndpointTlsTerminationModule TlsTermination
        {
            get { return new EndpointTlsTerminationModule(apiHttpClient); }
        }

        public EndpointIpPolicyModule IpPolicy
        {
            get { return new EndpointIpPolicyModule(apiHttpClient); }
        }

        public EndpointMutualTlsModule MutualTls
        {
            get { return new EndpointMutualTlsModule(apiHttpClient); }
        }

        public EndpointRequestHeadersModule RequestHeaders
        {
            get { return new EndpointRequestHeadersModule(apiHttpClient); }
        }

        public EndpointResponseHeadersModule ResponseHeaders
        {
            get { return new EndpointResponseHeadersModule(apiHttpClient); }
        }

        public EndpointOAuthModule Oauth
        {
            get { return new EndpointOAuthModule(apiHttpClient); }
        }

        public EndpointWebhookValidationModule WebhookValidation
        {
            get { return new EndpointWebhookValidationModule(apiHttpClient); }
        }

        public EndpointSamlModule Saml
        {
            get { return new EndpointSamlModule(apiHttpClient); }
        }

        public EndpointOidcModule Oidc
        {
            get { return new EndpointOidcModule(apiHttpClient); }
        }

    }
}
