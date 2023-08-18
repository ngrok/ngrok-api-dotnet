/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AwsRole
    {
        // <summary>
        // An ARN that specifies the role that ngrok should use to deliver to the
        // configured target.
        // </summary>
        [JsonProperty("role_arn")]
        public string RoleArn { get; set; }

        public override string ToString()
        {
            return $"AwsRole RoleArn={ RoleArn } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (RoleArn?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (AwsRole)obj;
            return (
                 this.RoleArn == other.RoleArn
            );
        }

    }
}
