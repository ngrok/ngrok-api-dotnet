
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgesHttpsRoutes
    {
        private IApiHttpClient apiClient;

        internal EdgesHttpsRoutes(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create an HTTPS Edge Route
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-routes-create
        public async Task<HttpsEdgeRoute> Create(HttpsEdgeRouteCreate arg)
        {
            Dictionary<string, string> query = null;
            HttpsEdgeRouteCreate body = arg;
            return await apiClient.Do<HttpsEdgeRoute>(
                path: $"/edges/https/{arg.EdgeId}/routes",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Get an HTTPS Edge Route by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-routes-get
        public async Task<HttpsEdgeRoute> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<HttpsEdgeRoute>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Updates an HTTPS Edge Route by ID. If a module is not specified in the update,
        // it will not be modified. However, each module configuration that is specified
        // will completely replace the existing value. There is no way to delete an
        // existing module via this API, instead use the delete module API.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-routes-update
        public async Task<HttpsEdgeRoute> Update(HttpsEdgeRouteUpdate arg)
        {
            Dictionary<string, string> query = null;
            HttpsEdgeRouteUpdate body = arg;
            return await apiClient.Do<HttpsEdgeRoute>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an HTTPS Edge Route by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-routes-delete
        public async Task Delete(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}
