/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // TLS Certificates are pairs of x509 certificates and their matching private
    //  key that can be used to terminate TLS traffic. TLS certificates are unused
    //  until they are attached to a Domain. TLS Certificates may also be
    //  provisioned by ngrok automatically for domains on which you have enabled
    //  automated certificate provisioning.
    // </summary>

    public class TlsCertificates
    {
        private IApiHttpClient apiClient;

        internal TlsCertificates(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Upload a new TLS certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tls-certificates-create
        public async Task<TlsCertificate> Create(TlsCertificateCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            TlsCertificateCreate body = arg;
            return await apiClient.Do<TlsCertificate>(
                path: $"/tls_certificates",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a TLS certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tls-certificates-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/tls_certificates/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about a TLS certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tls-certificates-get
        public async Task<TlsCertificate> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<TlsCertificate>(
                path: $"/tls_certificates/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<TlsCertificateList> ListPage(Paging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            Paging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            query = queryParams;
            return await apiClient.Do<TlsCertificateList>(
                path: $"/tls_certificates",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all TLS certificates on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tls-certificates-list
        public IAsyncEnumerable<TlsCertificate> List(string limit = null, string beforeId = null)
        {
            return new Iterator<TlsCertificate>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.TlsCertificates;
            });
        }

        // <summary>
        // Update attributes of a TLS Certificate by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tls-certificates-update
        public async Task<TlsCertificate> Update(TlsCertificateUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            TlsCertificateUpdate body = arg;
            return await apiClient.Do<TlsCertificate>(
                path: $"/tls_certificates/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}
