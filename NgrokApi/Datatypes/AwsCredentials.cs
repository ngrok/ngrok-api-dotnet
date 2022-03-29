
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AwsCredentials
    {
        // <summary>
        // The ID portion of an AWS access key.
        // </summary>
        [JsonProperty("aws_access_key_id")]
        public string AwsAccessKeyId { get; set; }
        // <summary>
        // The secret portion of an AWS access key.
        // </summary>
        [JsonProperty("aws_secret_access_key")]
        public string AwsSecretAccessKey { get; set; }

        public override string ToString()
        {
            return $"AwsCredentials AwsAccessKeyId={ AwsAccessKeyId }  AwsSecretAccessKey={ AwsSecretAccessKey } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (AwsAccessKeyId?.GetHashCode() ?? 0);

                hash = hash * 23 + (AwsSecretAccessKey?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (AwsCredentials)obj;
            return (
                 this.AwsAccessKeyId == other.AwsAccessKeyId
                && this.AwsSecretAccessKey == other.AwsSecretAccessKey
            );
        }

    }
}
