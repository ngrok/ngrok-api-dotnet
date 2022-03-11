
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // An SSH Certificate Authority is a pair of an SSH Certificate and its private
    //  key that can be used to sign other SSH host and user certificates.
    // </summary>

    public class SshCertificateAuthorities
    {
        private IApiHttpClient apiClient;

        internal SshCertificateAuthorities(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new SSH Certificate Authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-certificate-authorities-create
        public async Task<SshCertificateAuthority> Create(SshCertificateAuthorityCreate arg)
        {
            Dictionary<string, string> query = null;
            SshCertificateAuthorityCreate body = null;
            body = arg;

            return await apiClient.Do<SshCertificateAuthority>(
                  path: $"ssh_certificate_authorities",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an SSH Certificate Authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-certificate-authorities-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"ssh_certificate_authorities/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about an SSH Certficate Authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-certificate-authorities-get
        public async Task<SshCertificateAuthority> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<SshCertificateAuthority>(
                  path: $"ssh_certificate_authorities/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<SshCertificateAuthorityList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<SshCertificateAuthorityList>(
                  path: $"ssh_certificate_authorities",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all SSH Certificate Authorities on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-certificate-authorities-list
        public IAsyncEnumerable<SshCertificateAuthority> List(string limit = null, string beforeId = null)
        {
            return new Iterator<SshCertificateAuthority>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.SshCertificateAuthorities;
            });
        }

        // <summary>
        // Update an SSH Certificate Authority
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-certificate-authorities-update
        public async Task<SshCertificateAuthority> Update(SshCertificateAuthorityUpdate arg)
        {
            Dictionary<string, string> query = null;
            SshCertificateAuthorityUpdate body = null;
            body = arg;

            return await apiClient.Do<SshCertificateAuthority>(
                  path: $"ssh_certificate_authorities/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}
