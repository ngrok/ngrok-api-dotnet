
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventTargetFirehose
    {
        // <summary>
        // Configuration for how to authenticate into your AWS account. Exactly one of
        // <c>role</c> or <c>creds</c> should be configured.
        // </summary>
        [JsonProperty("auth")]
        public AwsAuth Auth { get; set; }
        // <summary>
        // An Amazon Resource Name specifying the Firehose delivery stream to deposit
        // events into.
        // </summary>
        [JsonProperty("delivery_stream_arn")]
        public string DeliveryStreamArn { get; set; }

        public override string ToString()
        {
            return $"EventTargetFirehose Auth={ Auth }  DeliveryStreamArn={ DeliveryStreamArn } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Auth?.GetHashCode() ?? 0);

                hash = hash * 23 + (DeliveryStreamArn?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventTargetFirehose)obj;
            return (
                 this.Auth == other.Auth
                && this.DeliveryStreamArn == other.DeliveryStreamArn
            );
        }

    }
}
