
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteWebsocketTcpConverterModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteWebsocketTcpConverterModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointWebsocketTcpConverter> Replace(EdgeRouteWebsocketTcpConverterReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointWebsocketTcpConverter body = arg.Module;
            return await apiClient.Do<EndpointWebsocketTcpConverter>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/websocket_tcp_converter",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointWebsocketTcpConverter> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointWebsocketTcpConverter>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/websocket_tcp_converter",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        public async Task Delete(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/websocket_tcp_converter",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}
