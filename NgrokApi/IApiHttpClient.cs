/* Code generated for API Clients. DO NOT EDIT. */

using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NgrokApi
{
    public interface IApiHttpClient
    {
        Task<T> Do<T>(HttpMethod method, string path, Dictionary<string, string> query = null, Object body = null);
        Task DoNoReturnBody<T>(HttpMethod method, string path, Dictionary<string, string> query = null, Object body = null);
        void LogTo(TextWriter debugStream);
        void UseMocks(bool useMocks);
        void PushMockResponse(int httpStatusCode, string responseData);
    }
}
