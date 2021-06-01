
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventTargetKinesis
    {
        // <summary>
        // Configuration for how to authenticate into your AWS account. Exactly one of
        // <c>role</c> or <c>creds</c> should be configured.
        // </summary>
        [JsonProperty("auth")]
        public AwsAuth Auth { get; set; }
        // <summary>
        // An Amazon Resource Name specifying the Kinesis stream to deposit events into.
        // </summary>
        [JsonProperty("stream_arn")]
        public string StreamArn { get; set; }

        public override string ToString()
        {
            return $"EventTargetKinesis Auth={ Auth }  StreamArn={ StreamArn } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Auth?.GetHashCode() ?? 0);

                hash = hash * 23 + (StreamArn?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventTargetKinesis)obj;
            return (
                 this.Auth == other.Auth
                && this.StreamArn == other.StreamArn
            );
        }

    }
}
