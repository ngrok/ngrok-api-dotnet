
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventTargetCloudwatchLogs
    {
        // <summary>
        // Configuration for how to authenticate into your AWS account. Exactly one of
        // <c>role</c> or <c>creds</c> should be configured.
        // </summary>
        [JsonProperty("auth")]
        public AwsAuth Auth { get; set; }
        // <summary>
        // An Amazon Resource Name specifying the CloudWatch Logs group to deposit events
        // into.
        // </summary>
        [JsonProperty("log_group_arn")]
        public string LogGroupArn { get; set; }

        public override string ToString()
        {
            return $"EventTargetCloudwatchLogs Auth={ Auth }  LogGroupArn={ LogGroupArn } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Auth?.GetHashCode() ?? 0);

                hash = hash * 23 + (LogGroupArn?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventTargetCloudwatchLogs)obj;
            return (
                 this.Auth == other.Auth
                && this.LogGroupArn == other.LogGroupArn
            );
        }

    }
}
