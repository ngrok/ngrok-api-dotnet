
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // SSH Host Certificates along with the corresponding private key allows an SSH
    //  server to assert its authenticity to connecting SSH clients who trust the
    //  SSH Certificate Authority that was used to sign the certificate.
    // </summary>

    public class SshHostCertificates
    {
        private IApiHttpClient apiClient;

        internal SshHostCertificates(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new SSH Host Certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-host-certificates-create
        public async Task<SshHostCertificate> Create(SshHostCertificateCreate arg)
        {
            Dictionary<string, string> query = null;
            SshHostCertificateCreate body = null;
            body = arg;

            return await apiClient.Do<SshHostCertificate>(
                  path: $"/ssh_host_certificates",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an SSH Host Certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-host-certificates-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/ssh_host_certificates/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about an SSH Host Certficate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-host-certificates-get
        public async Task<SshHostCertificate> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<SshHostCertificate>(
                  path: $"/ssh_host_certificates/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<SshHostCertificateList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<SshHostCertificateList>(
                  path: $"/ssh_host_certificates",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all SSH Host Certificates issued on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-host-certificates-list
        public IAsyncEnumerable<SshHostCertificate> List(string limit = null, string beforeId = null)
        {
            return new Iterator<SshHostCertificate>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.SshHostCertificates;
            });
        }

        // <summary>
        // Update an SSH Host Certificate
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-host-certificates-update
        public async Task<SshHostCertificate> Update(SshHostCertificateUpdate arg)
        {
            Dictionary<string, string> query = null;
            SshHostCertificateUpdate body = null;
            body = arg;

            return await apiClient.Do<SshHostCertificate>(
                  path: $"/ssh_host_certificates/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}
