/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class BotUserList
    {
        // <summary>
        // the list of all bot users on this account
        // </summary>
        [JsonProperty("bot_users")]
        public List<BotUser> BotUsers { get; set; }
        // <summary>
        // URI of the bot users list API resource
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
            return $"BotUserList BotUsers={ BotUsers }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BotUsers?.GetHashCode() ?? 0);

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
            var other = (BotUserList)obj;
            return (
                 this.BotUsers == other.BotUsers
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}
