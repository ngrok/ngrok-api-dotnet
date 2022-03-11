using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventTargetFirehose
    {
        // <summary>
        // Configuration for how to authenticate into your AWS account. Exactly one of
        // <c>role</c> or <c>creds</c> should be configured.
        // </summary>
        [JsonPropertyName("auth")]
        public AwsAuth Auth { get; set; }
        // <summary>
        // An Amazon Resource Name specifying the Firehose delivery stream to deposit
        // events into.
        // </summary>
        [JsonPropertyName("delivery_stream_arn")]
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
            var other = (EventTargetFirehose)obj;
            return (
                 this.Auth == other.Auth
                && this.DeliveryStreamArn == other.DeliveryStreamArn
            );
        }

    }
}
