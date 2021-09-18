
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Reserved Domains are hostnames that you can listen for traffic on. Domains
    //  can be used to listen for http, https or tls traffic. You may use a domain
    //  that you own by creating a CNAME record specified in the returned resource.
    //  This CNAME record points traffic for that domain to ngrok's edge servers.
    // </summary>

    public class ReservedDomains
    {
        private IApiHttpClient apiClient;

        internal ReservedDomains(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-create
        public async Task<ReservedDomain> Create(ReservedDomainCreate arg)
        {
            Dictionary<string, string> query = null;
            ReservedDomainCreate body = null;
            body = arg;

            return await apiClient.Do<ReservedDomain>(
                  path: $"/reserved_domains",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/reserved_domains/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get the details of a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-get
        public async Task<ReservedDomain> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<ReservedDomain>(
                  path: $"/reserved_domains/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<ReservedDomainList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<ReservedDomainList>(
                  path: $"/reserved_domains",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all reserved domains on this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-list
        public IAsyncEnumerable<ReservedDomain> List(string limit = null, string beforeId = null)
        {
            return new Iterator<ReservedDomain>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.ReservedDomains;
            });
        }

        // <summary>
        // Update the attributes of a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-update
        public async Task<ReservedDomain> Update(ReservedDomainUpdate arg)
        {
            Dictionary<string, string> query = null;
            ReservedDomainUpdate body = null;
            body = arg;

            return await apiClient.Do<ReservedDomain>(
                  path: $"/reserved_domains/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Detach the certificate management policy attached to a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-delete-certificate-management-policy
        public async Task DeleteCertificateManagementPolicy(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/reserved_domains/{arg.Id}/certificate_management_policy",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Detach the certificate attached to a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-delete-certificate
        public async Task DeleteCertificate(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/reserved_domains/{arg.Id}/certificate",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Detach the http endpoint configuration attached to a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-delete-http-endpoint-config
        public async Task DeleteHttpEndpointConfig(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/reserved_domains/{arg.Id}/http_endpoint_configuration",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Detach the https endpoint configuration attached to a reserved domain.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-domains-delete-https-endpoint-config
        public async Task DeleteHttpsEndpointConfig(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/reserved_domains/{arg.Id}/https_endpoint_configuration",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}
