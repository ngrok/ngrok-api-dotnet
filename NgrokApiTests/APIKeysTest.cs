/* Code generated for API Clients. DO NOT EDIT. */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using NgrokApi;

namespace NgrokApiTests
{
    [TestClass]
    public class NgrokApiTest
    {
        [TestMethod]
        public async Task TestHttpClient()
        {
            var apiKey = Environment.GetEnvironmentVariable("NGROK_API_KEY");

            IApiHttpClient apiHttpClient = new ApiHttpClient(apiKey);
            apiHttpClient.LogTo(Console.Out);
            var noMock = Environment.GetEnvironmentVariable("NGROK_TEST_NOMOCK") ?? "";
            apiHttpClient.UseMocks(noMock == "");

            // Construct API client
            Ngrok ngrok = new Ngrok(apiHttpClient);

            // initial list
            apiHttpClient.PushMockResponse(200, @"{""keys"":[],""uri"":""https://api.ngrok.com/api_keys"",""next_page_uri"":null}");
            var apiKeysList = ngrok.ApiKeys.List();
            apiKeysList.ToListAsync();

            // create api key
            var apiKeyDesc = "hello .NET";
            apiHttpClient.PushMockResponse(201, @"{""id"":""ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""uri"":""https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""description"":""hello .NET"",""metadata"":"""",""created_at"":""2021-05-31T22:12:20Z"",""token"":""1tJthkYN0FYv68ejhHsE32NLGhX_V7TbQozQhH8XGGzHZ6bP""}");
            var apiKeyCreated = await ngrok.ApiKeys.Create(new ApiKeyCreate()
            {
                Description = apiKeyDesc,
            });
            Assert.AreEqual(apiKeyDesc, apiKeyCreated.Description);

            // mock returns apiKey
            apiHttpClient.PushMockResponse(200, @"{""id"":""ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""uri"":""https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""description"":""hello .NET"",""metadata"":"""",""created_at"":""2021-05-31T22:12:20Z"",""token"":null}");
            var apiKeyInstance = await ngrok.ApiKeys.Get(apiKeyCreated.Id);
            apiKeyCreated.Token = null;
            Assert.AreEqual(apiKeyCreated, apiKeyInstance);
            System.Diagnostics.Debug.WriteLine(apiKeyCreated.Uri);

            // update
            apiHttpClient.PushMockResponse(200, @"{""id"":""ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""uri"":""https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""description"":""hello .NET"",""metadata"":""{\""hello\"": \""metadata\""}"",""created_at"":""2021-05-31T22:12:20Z"",""token"":null}");
            var apiKeyMeta = "{\"hello\": \"metadata\"}";
            var apiKeyUpdated = await ngrok.ApiKeys.Update(new ApiKeyUpdate() { Id = apiKeyCreated.Id, Metadata = apiKeyMeta });
            Assert.AreEqual(apiKeyCreated.Id, apiKeyUpdated.Id);
            Assert.AreEqual(apiKeyMeta, apiKeyUpdated.Metadata);

            // get the instance again and assert it's the same
            apiHttpClient.PushMockResponse(200, @"{""id"":""ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""uri"":""https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""description"":""hello .NET"",""metadata"":""{\""hello\"": \""metadata\""}"",""created_at"":""2021-05-31T22:12:20Z"",""token"":null}");
            var apiKeyAfterUpdate = await ngrok.ApiKeys.Get(apiKeyCreated.Id);
            Assert.AreEqual(apiKeyUpdated, apiKeyAfterUpdate);

            // value is present in list
            apiHttpClient.PushMockResponse(200, @"{""keys"":[{""id"":""ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""uri"":""https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""description"":""hello .NET"",""metadata"":""{\""hello\"": \""metadata\""}"",""created_at"":""2021-05-31T22:12:20Z"",""token"":null}],""uri"":""https://api.ngrok.com/api_keys"",""next_page_uri"":null}");
            apiHttpClient.PushMockResponse(200, @"{""keys"":[],""uri"":""https://api.ngrok.com/api_keys"",""next_page_uri"":null}");
            var postUpdateList = ngrok.ApiKeys.List();
            Assert.IsTrue((await postUpdateList.ToListAsync()).Contains(apiKeyAfterUpdate));

            // delete
            apiHttpClient.PushMockResponse(204, "");
            await ngrok.ApiKeys.Delete(apiKeyCreated.Id);

            // 404 after delete
            try
            {
                apiHttpClient.PushMockResponse(404, @"{""status_code"":404,""msg"":""Resource not found"",""details"":{""operation_id"":""op_1tJthkRrNlXtTS98ok3Bptqc8T7""}}");
                await ngrok.ApiKeys.Get(apiKeyCreated.Id);
                Assert.Fail();
            }
            catch (NgrokException e)
            {
                Assert.AreEqual(e.HttpStatusCode, 404);
            }
        }

        [TestMethod]
        public async Task TestUri()
        {
            var apiKey = Environment.GetEnvironmentVariable("NGROK_API_KEY");

            IApiHttpClient apiHttpClient = new ApiHttpClient(apiKey);
            apiHttpClient.LogTo(Console.Out);
            var noMock = Environment.GetEnvironmentVariable("NGROK_TEST_NOMOCK") ?? "";
            apiHttpClient.UseMocks(noMock == "");

            // Construct API client
            Ngrok ngrok = new Ngrok(apiHttpClient);

            // initial list
            apiHttpClient.PushMockResponse(200, @"{""keys"":[],""uri"":""https://api.ngrok.com/api_keys"",""next_page_uri"":null}");
            var apiKeysList = ngrok.ApiKeys.List();
            apiKeysList.ToListAsync();

            // create api key to use for testing Uri
            var apiKeyDesc = "hello .NET";
            apiHttpClient.PushMockResponse(201, @"{""id"":""ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""uri"":""https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX"",""description"":""hello .NET"",""metadata"":"""",""created_at"":""2021-05-31T22:12:20Z"",""token"":""1tJthkYN0FYv68ejhHsE32NLGhX_V7TbQozQhH8XGGzHZ6bP""}");
            var apiKeyCreated = await ngrok.ApiKeys.Create(new ApiKeyCreate()
            {
                Description = apiKeyDesc,
            });

            Assert.AreEqual(apiKeyCreated.Uri.AbsolutePath, "/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX");
            Assert.AreEqual(apiKeyCreated.Uri.AbsoluteUri, "https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX");
            Assert.AreEqual(apiKeyCreated.Uri.DnsSafeHost, "api.ngrok.com");
            Assert.AreEqual(apiKeyCreated.Uri.Fragment, "");
            Assert.AreEqual(apiKeyCreated.Uri.Host, "api.ngrok.com");
            Assert.AreEqual(apiKeyCreated.Uri.HostNameType, System.UriHostNameType.Dns);
            Assert.AreEqual(apiKeyCreated.Uri.IdnHost, "api.ngrok.com");
            Assert.AreEqual(apiKeyCreated.Uri.IsAbsoluteUri, true);
            Assert.AreEqual(apiKeyCreated.Uri.IsDefaultPort, true);
            Assert.AreEqual(apiKeyCreated.Uri.IsFile, false);
            Assert.AreEqual(apiKeyCreated.Uri.IsLoopback, false);
            Assert.AreEqual(apiKeyCreated.Uri.IsUnc, false);
            Assert.AreEqual(apiKeyCreated.Uri.LocalPath, "/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX");
            Assert.AreEqual(apiKeyCreated.Uri.OriginalString, "https://api.ngrok.com/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX");
            Assert.AreEqual(apiKeyCreated.Uri.PathAndQuery, "/api_keys/ak_1tJthkYN0FYv68ejhHsE32NLGhX");
            Assert.AreEqual(apiKeyCreated.Uri.Port, 443);
            Assert.AreEqual(apiKeyCreated.Uri.Query, "");
            Assert.AreEqual(apiKeyCreated.Uri.Scheme, "https");
            Assert.AreEqual(string.Join(", ", apiKeyCreated.Uri.Segments), "/, api_keys/, ak_1tJthkYN0FYv68ejhHsE32NLGhX");
            Assert.AreEqual(apiKeyCreated.Uri.UserEscaped, false);
            Assert.AreEqual(apiKeyCreated.Uri.UserInfo, "");
        }
    }
}
