/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AwsAuth
    {
        // <summary>
        // A role for ngrok to assume on your behalf to deposit events into your AWS
        // account.
        // </summary>
        [JsonProperty("role")]
        public AwsRole Role { get; set; }
        // <summary>
        // Credentials to your AWS account if you prefer ngrok to sign in with long-term
        // access keys.
        // </summary>
        [JsonProperty("creds")]
        public AwsCredentials Creds { get; set; }

        public override string ToString()
        {
            return $"AwsAuth Role={ Role }  Creds={ Creds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Role?.GetHashCode() ?? 0);

                hash = hash * 23 + (Creds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (AwsAuth)obj;
            return (
                 this.Role == other.Role
                && this.Creds == other.Creds
            );
        }

    }
}
