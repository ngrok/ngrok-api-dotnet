using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventTarget
    {
        // <summary>
        // Configuration used to send events to Amazon Kinesis Data Firehose.
        // </summary>
        [JsonPropertyName("firehose")]
        public EventTargetFirehose Firehose { get; set; }
        // <summary>
        // Configuration used to send events to Amazon Kinesis.
        // </summary>
        [JsonPropertyName("kinesis")]
        public EventTargetKinesis Kinesis { get; set; }
        // <summary>
        // Configuration used to send events to Amazon CloudWatch Logs.
        // </summary>
        [JsonPropertyName("cloudwatch_logs")]
        public EventTargetCloudwatchLogs CloudwatchLogs { get; set; }

        public override string ToString()
        {
            return $"EventTarget Firehose={ Firehose }  Kinesis={ Kinesis }  CloudwatchLogs={ CloudwatchLogs } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Firehose?.GetHashCode() ?? 0);

                hash = hash * 23 + (Kinesis?.GetHashCode() ?? 0);

                hash = hash * 23 + (CloudwatchLogs?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventTarget)obj;
            return (
                 this.Firehose == other.Firehose
                && this.Kinesis == other.Kinesis
                && this.CloudwatchLogs == other.CloudwatchLogs
            );
        }

    }
}
