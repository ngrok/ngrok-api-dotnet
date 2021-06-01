using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime;
using System.Linq;
using Newtonsoft.Json;

namespace NgrokApi
{
    internal class ApiHttpClient : IApiHttpClient
    {
        static readonly HttpClient client = new HttpClient();
        private Uri baseUrl;
        private string apiKey;
        private TextWriter debugStream;
        private bool useMocks;
        private Queue<HttpResponseMessage> mockResponses = new Queue<HttpResponseMessage>();

        public ApiHttpClient(string apiKey, string baseUrl = "https://api.ngrok.com")
        {
            this.apiKey = apiKey;
            this.baseUrl = new Uri(baseUrl);
        }

        public void LogTo(TextWriter debugStream)
        {
            this.debugStream = debugStream;
        }

        public void UseMocks(bool useMocks)
        {
            this.useMocks = useMocks;
        }

        public void PushMockResponse(int statusCode, string body)
        {
            var resp = new HttpResponseMessage((HttpStatusCode)statusCode);
            resp.Content = new StringContent(body, Encoding.UTF8, "application/json");
            this.mockResponses.Enqueue(resp);
        }

        public async Task<T> Do<T>(HttpMethod method, string path, Dictionary<string, string> query = null, Object body = null)
        {
            var msg = PrepareRequest(method, path, query, body);
            HttpResponseMessage response = await SendAsync(msg);
            await MaybeThrowException(response);
            string responseBody = await response.Content.ReadAsStringAsync();
            WriteDebug($"{response.StatusCode}\n{responseBody}");
            T responseObject = JsonConvert.DeserializeObject<T>(responseBody);
            return responseObject;
        }

        public async Task DoNoReturnBody<T>(HttpMethod method, string path, Dictionary<string, string> query = null, Object body = null)
        {
            var msg = PrepareRequest(method, path, query, body);
            HttpResponseMessage response = await SendAsync(msg);
            await MaybeThrowException(response);
        }

        private async Task<HttpResponseMessage> SendAsync(HttpRequestMessage msg)
        {
            if (useMocks)
            {
                return mockResponses.Dequeue();
            }
            else
            {
                return await client.SendAsync(msg);
            }
        }

        private async Task MaybeThrowException(HttpResponseMessage response)
        {
            if (response.StatusCode < HttpStatusCode.BadRequest)
            {
                return;
            }
            string responseBody = await response.Content.ReadAsStringAsync();
            WriteDebug($"{response.StatusCode}\n{responseBody}");
            Error err = JsonConvert.DeserializeObject<Error>(responseBody);
            throw new NgrokException(err);
        }

        private HttpRequestMessage PrepareRequest(HttpMethod method, string path, Dictionary<string, string> query = null, Object body = null)
        {
            if (query != null && query.Count != 0)
            {
                var filteredQuery = query.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value);
                var queryString = new FormUrlEncodedContent(filteredQuery);
                path = path + "?" + queryString.ReadAsStringAsync().Result;
            }
            HttpRequestMessage msg = new HttpRequestMessage(method, new Uri(baseUrl, path));
            msg.Headers.Add("ngrok-version", "2");
            msg.Headers.Add("authorization", "Bearer " + this.apiKey);
            if (body != null)
            {
                var bodyString = JsonConvert.SerializeObject(body);
                var bodyBytes = Encoding.Unicode.GetBytes(bodyString);
                msg.Content = new StringContent(bodyString, Encoding.UTF8, "application/json");
                WriteDebug($"{method} {path}\n{bodyString}");
            }
            else
            {
                WriteDebug($"{method} {path}");
            }
            return msg;
        }

        private void WriteDebug(string text)
        {
            debugStream.WriteLine(text);
        }
    }
}
