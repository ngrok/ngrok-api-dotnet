
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
            Dictionary<string, string> query = null;
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

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/certificate_authorities/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about a certficate authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-certificate-authorities-get
        public async Task<CertificateAuthority> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<CertificateAuthority>(
                path: $"/certificate_authorities/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<CertificateAuthorityList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
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
                var result = await this.ListPage(new Paging()
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
            Dictionary<string, string> query = null;
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
