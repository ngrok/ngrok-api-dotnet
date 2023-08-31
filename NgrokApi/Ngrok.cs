/* Code generated for API Clients. DO NOT EDIT. */


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

        public ApplicationSessions ApplicationSessions
        {
            get { return new ApplicationSessions(apiHttpClient); }
        }

        public ApplicationUsers ApplicationUsers
        {
            get { return new ApplicationUsers(apiHttpClient); }
        }

        public TunnelSessions TunnelSessions
        {
            get { return new TunnelSessions(apiHttpClient); }
        }

        public CertificateAuthorities CertificateAuthorities
        {
            get { return new CertificateAuthorities(apiHttpClient); }
        }

        public Credentials Credentials
        {
            get { return new Credentials(apiHttpClient); }
        }

        public Endpoints Endpoints
        {
            get { return new Endpoints(apiHttpClient); }
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

        public Tunnels Tunnels
        {
            get { return new Tunnels(apiHttpClient); }
        }


        public BackendsNamespace Backends
        {
            get { return new BackendsNamespace(apiHttpClient); }
        }

        public EdgesNamespace Edges
        {
            get { return new EdgesNamespace(apiHttpClient); }
        }

        public EdgeModulesNamespace EdgeModules
        {
            get { return new EdgeModulesNamespace(apiHttpClient); }
        }

    }
    public class BackendsNamespace
    {
        private IApiHttpClient apiHttpClient;
        public BackendsNamespace(IApiHttpClient apiHttpClient)
        {
            this.apiHttpClient = apiHttpClient;
        }

        public FailoverBackends Failover
        {
            get { return new FailoverBackends(apiHttpClient); }
        }

        public HttpResponseBackends HttpResponse
        {
            get { return new HttpResponseBackends(apiHttpClient); }
        }

        public TunnelGroupBackends TunnelGroup
        {
            get { return new TunnelGroupBackends(apiHttpClient); }
        }

        public WeightedBackends Weighted
        {
            get { return new WeightedBackends(apiHttpClient); }
        }

    }
    public class EdgesNamespace
    {
        private IApiHttpClient apiHttpClient;
        public EdgesNamespace(IApiHttpClient apiHttpClient)
        {
            this.apiHttpClient = apiHttpClient;
        }

        public EdgesHttpsRoutes HttpsRoutes
        {
            get { return new EdgesHttpsRoutes(apiHttpClient); }
        }

        public EdgesHttps Https
        {
            get { return new EdgesHttps(apiHttpClient); }
        }

        public EdgesTcp Tcp
        {
            get { return new EdgesTcp(apiHttpClient); }
        }

        public EdgesTls Tls
        {
            get { return new EdgesTls(apiHttpClient); }
        }

    }
    public class EdgeModulesNamespace
    {
        private IApiHttpClient apiHttpClient;
        public EdgeModulesNamespace(IApiHttpClient apiHttpClient)
        {
            this.apiHttpClient = apiHttpClient;
        }

        public HttpsEdgeMutualTlsModule HttpsEdgeMutualTls
        {
            get { return new HttpsEdgeMutualTlsModule(apiHttpClient); }
        }

        public HttpsEdgeTlsTerminationModule HttpsEdgeTlsTermination
        {
            get { return new HttpsEdgeTlsTerminationModule(apiHttpClient); }
        }

        public EdgeRouteBackendModule HttpsEdgeRouteBackend
        {
            get { return new EdgeRouteBackendModule(apiHttpClient); }
        }

        public EdgeRouteIpRestrictionModule HttpsEdgeRouteIpRestriction
        {
            get { return new EdgeRouteIpRestrictionModule(apiHttpClient); }
        }

        public EdgeRouteRequestHeadersModule HttpsEdgeRouteRequestHeaders
        {
            get { return new EdgeRouteRequestHeadersModule(apiHttpClient); }
        }

        public EdgeRouteResponseHeadersModule HttpsEdgeRouteResponseHeaders
        {
            get { return new EdgeRouteResponseHeadersModule(apiHttpClient); }
        }

        public EdgeRouteCompressionModule HttpsEdgeRouteCompression
        {
            get { return new EdgeRouteCompressionModule(apiHttpClient); }
        }

        public EdgeRouteCircuitBreakerModule HttpsEdgeRouteCircuitBreaker
        {
            get { return new EdgeRouteCircuitBreakerModule(apiHttpClient); }
        }

        public EdgeRouteWebhookVerificationModule HttpsEdgeRouteWebhookVerification
        {
            get { return new EdgeRouteWebhookVerificationModule(apiHttpClient); }
        }

        public EdgeRouteOAuthModule HttpsEdgeRouteOauth
        {
            get { return new EdgeRouteOAuthModule(apiHttpClient); }
        }

        public EdgeRouteSamlModule HttpsEdgeRouteSaml
        {
            get { return new EdgeRouteSamlModule(apiHttpClient); }
        }

        public EdgeRouteOidcModule HttpsEdgeRouteOidc
        {
            get { return new EdgeRouteOidcModule(apiHttpClient); }
        }

        public EdgeRouteWebsocketTcpConverterModule HttpsEdgeRouteWebsocketTcpConverter
        {
            get { return new EdgeRouteWebsocketTcpConverterModule(apiHttpClient); }
        }

        public TcpEdgeBackendModule TcpEdgeBackend
        {
            get { return new TcpEdgeBackendModule(apiHttpClient); }
        }

        public TcpEdgeIpRestrictionModule TcpEdgeIpRestriction
        {
            get { return new TcpEdgeIpRestrictionModule(apiHttpClient); }
        }

        public TlsEdgeBackendModule TlsEdgeBackend
        {
            get { return new TlsEdgeBackendModule(apiHttpClient); }
        }

        public TlsEdgeIpRestrictionModule TlsEdgeIpRestriction
        {
            get { return new TlsEdgeIpRestrictionModule(apiHttpClient); }
        }

        public TlsEdgeMutualTlsModule TlsEdgeMutualTls
        {
            get { return new TlsEdgeMutualTlsModule(apiHttpClient); }
        }

        public TlsEdgeTlsTerminationModule TlsEdgeTlsTermination
        {
            get { return new TlsEdgeTlsTerminationModule(apiHttpClient); }
        }

    }
}
