
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ApplicationSessionList
    {
        // <summary>
        // list of all application sessions on this account
        // </summary>
        [JsonProperty("application_sessions")]
        public List<ApplicationSession> ApplicationSessions { get; set; }
        // <summary>
        // URI of the application session list API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonProperty("next_page_uri")]
        public Uri NextPageUri { get; set; }

        public override string ToString()
        {
            return $"ApplicationSessionList ApplicationSessions={ ApplicationSessions }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ApplicationSessions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ApplicationSessionList)obj;
            return (
                 this.ApplicationSessions == other.ApplicationSessions
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
