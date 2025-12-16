/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Certificate Authorities are x509 certificates that are used to sign other
    //  x509 certificates. Attach a Certificate Authority to the Mutual TLS module
    //  to verify that the TLS certificate presented by a client has been signed by
    //  this CA. Certificate Authorities  are used only for mTLS validation only and
    //  thus a private key is not included in the resource.
    // </summary>

    public class CertificateAuthorities
    {
        private IApiHttpClient apiClient;

        internal CertificateAuthorities(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Upload a new Certificate Authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-certificate-authorities-create
        public async Task<CertificateAuthority> Create(CertificateAuthorityCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            CertificateAuthorityCreate body = arg;
            return await apiClient.Do<CertificateAuthority>(
                path: $"/certificate_authorities",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a Certificate Authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-certificate-authorities-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/certificate_authorities/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about a certificate authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-certificate-authorities-get
        public async Task<CertificateAuthority> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<CertificateAuthority>(
                path: $"/certificate_authorities/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<CertificateAuthorityList> ListPage(FilteredPaging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            FilteredPaging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            if (arg.Filter != null) queryParams.Add(new KeyValuePair<string, string>("filter", arg.Filter));
            query = queryParams;
            return await apiClient.Do<CertificateAuthorityList>(
                path: $"/certificate_authorities",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all Certificate Authority on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-certificate-authorities-list
        public IAsyncEnumerable<CertificateAuthority> List(string limit = null, string beforeId = null)
        {
            return new Iterator<CertificateAuthority>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new FilteredPaging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.CertificateAuthorities;
            });
        }

        // <summary>
        // Update attributes of a Certificate Authority by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-certificate-authorities-update
        public async Task<CertificateAuthority> Update(CertificateAuthorityUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            CertificateAuthorityUpdate body = arg;
            return await apiClient.Do<CertificateAuthority>(
                path: $"/certificate_authorities/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}
