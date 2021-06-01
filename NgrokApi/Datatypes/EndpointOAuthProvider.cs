
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

        public override string ToString()
        {
            return $"EndpointOAuthProvider Github={ Github }  Facebook={ Facebook }  Microsoft={ Microsoft }  Google={ Google } ";
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

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointOAuthProvider)obj;
            return (
                 this.Github == other.Github
                && this.Facebook == other.Facebook
                && this.Microsoft == other.Microsoft
                && this.Google == other.Google
            );
        }

    }
}
