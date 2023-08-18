/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // SSH User Certificates are presented by SSH clients when connecting to an SSH
    //  server to authenticate their connection. The SSH server must trust the SSH
    //  Certificate Authority used to sign the certificate.
    // </summary>

    public class SshUserCertificates
    {
        private IApiHttpClient apiClient;

        internal SshUserCertificates(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new SSH User Certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-user-certificates-create
        public async Task<SshUserCertificate> Create(SshUserCertificateCreate arg)
        {
            Dictionary<string, string> query = null;
            SshUserCertificateCreate body = arg;
            return await apiClient.Do<SshUserCertificate>(
                path: $"/ssh_user_certificates",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an SSH User Certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-user-certificates-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/ssh_user_certificates/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about an SSH User Certficate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-user-certificates-get
        public async Task<SshUserCertificate> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<SshUserCertificate>(
                path: $"/ssh_user_certificates/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<SshUserCertificateList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<SshUserCertificateList>(
                path: $"/ssh_user_certificates",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all SSH User Certificates issued on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-user-certificates-list
        public IAsyncEnumerable<SshUserCertificate> List(string limit = null, string beforeId = null)
        {
            return new Iterator<SshUserCertificate>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.SshUserCertificates;
            });
        }

        // <summary>
        // Update an SSH User Certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-user-certificates-update
        public async Task<SshUserCertificate> Update(SshUserCertificateUpdate arg)
        {
            Dictionary<string, string> query = null;
            SshUserCertificateUpdate body = arg;
            return await apiClient.Do<SshUserCertificate>(
                path: $"/ssh_user_certificates/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}
