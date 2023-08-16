/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointOAuthProvider
    {
        // <summary>
        // configuration for using github as the identity provider
        // </summary>
        [JsonProperty("github")]
        public EndpointOAuthGitHub Github { get; set; }
        // <summary>
        // configuration for using facebook as the identity provider
        // </summary>
        [JsonProperty("facebook")]
        public EndpointOAuthFacebook Facebook { get; set; }
        // <summary>
        // configuration for using microsoft as the identity provider
        // </summary>
        [JsonProperty("microsoft")]
        public EndpointOAuthMicrosoft Microsoft { get; set; }
        // <summary>
        // configuration for using google as the identity provider
        // </summary>
        [JsonProperty("google")]
        public EndpointOAuthGoogle Google { get; set; }
        // <summary>
        // configuration for using linkedin as the identity provider
        // </summary>
        [JsonProperty("linkedin")]
        public EndpointOAuthLinkedIn Linkedin { get; set; }
        // <summary>
        // configuration for using gitlab as the identity provider
        // </summary>
        [JsonProperty("gitlab")]
        public EndpointOAuthGitLab Gitlab { get; set; }
        // <summary>
        // configuration for using twitch as the identity provider
        // </summary>
        [JsonProperty("twitch")]
        public EndpointOAuthTwitch Twitch { get; set; }
        // <summary>
        // configuration for using amazon as the identity provider
        // </summary>
        [JsonProperty("amazon")]
        public EndpointOAuthAmazon Amazon { get; set; }

        public override string ToString()
        {
            return $"EndpointOAuthProvider Github={ Github }  Facebook={ Facebook }  Microsoft={ Microsoft }  Google={ Google }  Linkedin={ Linkedin }  Gitlab={ Gitlab }  Twitch={ Twitch }  Amazon={ Amazon } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Github?.GetHashCode() ?? 0);

                hash = hash * 23 + (Facebook?.GetHashCode() ?? 0);

                hash = hash * 23 + (Microsoft?.GetHashCode() ?? 0);

                hash = hash * 23 + (Google?.GetHashCode() ?? 0);

                hash = hash * 23 + (Linkedin?.GetHashCode() ?? 0);

                hash = hash * 23 + (Gitlab?.GetHashCode() ?? 0);

                hash = hash * 23 + (Twitch?.GetHashCode() ?? 0);

                hash = hash * 23 + (Amazon?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointOAuthProvider)obj;
            return (
                 this.Github == other.Github
                && this.Facebook == other.Facebook
                && this.Microsoft == other.Microsoft
                && this.Google == other.Google
                && this.Linkedin == other.Linkedin
                && this.Gitlab == other.Gitlab
                && this.Twitch == other.Twitch
                && this.Amazon == other.Amazon
            );
        }

    }
}
