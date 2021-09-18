
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Abuse Reports allow you to submit take-down requests for URLs hosted by
    //  ngrok that violate ngrok's terms of service.
    // </summary>

    public class AbuseReports
    {
        private IApiHttpClient apiClient;

        internal AbuseReports(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Creates a new abuse report which will be reviewed by our system and abuse
        // response team. This API is only available to authorized accounts. Contact
        // abuse@ngrok.com to request access
        // </summary>
        //
        // https://ngrok.com/docs/api#api-abuse-reports-create
        public async Task<AbuseReport> Create(AbuseReportCreate arg)
        {
            Dictionary<string, string> query = null;
            AbuseReportCreate body = null;
            body = arg;

            return await apiClient.Do<AbuseReport>(
                  path: $"/abuse_reports",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Get the detailed status of abuse report by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-abuse-reports-get
        public async Task<AbuseReport> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<AbuseReport>(
                  path: $"/abuse_reports/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
    }
}
