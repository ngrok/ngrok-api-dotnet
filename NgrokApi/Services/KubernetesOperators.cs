/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // KubernetesOperators is used by the Kubernetes Operator to register and
    //  manage its own resource, as well as for users to see active kubernetes
    //  clusters.
    // </summary>

    public class KubernetesOperators
    {
        private IApiHttpClient apiClient;

        internal KubernetesOperators(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Kubernetes Operator
        // </summary>
        //
        // https://ngrok.com/docs/api#api-kubernetes-operators-create
        public async Task<KubernetesOperator> Create(KubernetesOperatorCreate arg)
        {
            Dictionary<string, string> query = null;
            KubernetesOperatorCreate body = arg;
            return await apiClient.Do<KubernetesOperator>(
                path: $"/kubernetes_operators",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Update an existing Kubernetes operator by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-kubernetes-operators-update
        public async Task<KubernetesOperator> Update(KubernetesOperatorUpdate arg)
        {
            Dictionary<string, string> query = null;
            KubernetesOperatorUpdate body = arg;
            return await apiClient.Do<KubernetesOperator>(
                path: $"/kubernetes_operators/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a Kubernetes Operator
        // </summary>
        //
        // https://ngrok.com/docs/api#api-kubernetes-operators-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/kubernetes_operators/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get of a Kubernetes Operator
        // </summary>
        //
        // https://ngrok.com/docs/api#api-kubernetes-operators-get
        public async Task<KubernetesOperator> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<KubernetesOperator>(
                path: $"/kubernetes_operators/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<KubernetesOperatorList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<KubernetesOperatorList>(
                path: $"/kubernetes_operators",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all Kubernetes Operators owned by this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-kubernetes-operators-list
        public IAsyncEnumerable<KubernetesOperator> List(string limit = null, string beforeId = null)
        {
            return new Iterator<KubernetesOperator>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Operators;
            });
        }

        private async Task<EndpointList> GetBoundEndpointsPage(ItemPaging arg)

        {
            Dictionary<string, string> query = null;
            ItemPaging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<EndpointList>(
                path: $"/kubernetes_operators/{arg.Id}/bound_endpoints",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List Endpoints bound to a Kubernetes Operator
        // </summary>
        //
        // https://ngrok.com/docs/api#api-kubernetes-operators-get-bound-endpoints
        public IAsyncEnumerable<Endpoint> GetBoundEndpoints(string id, string limit = null, string beforeId = null)
        {
            return new Iterator<Endpoint>(beforeId, async lastId =>
            {
                var result = await this.GetBoundEndpointsPage(new ItemPaging()
                {
                    Id = id,
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Endpoints;
            });
        }
    }
}
