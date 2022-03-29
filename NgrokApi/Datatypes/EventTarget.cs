
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventTarget
    {
        // <summary>
        // Configuration used to send events to Amazon Kinesis Data Firehose.
        // </summary>
        [JsonProperty("firehose")]
        public EventTargetFirehose Firehose { get; set; }
        // <summary>
        // Configuration used to send events to Amazon Kinesis.
        // </summary>
        [JsonProperty("kinesis")]
        public EventTargetKinesis Kinesis { get; set; }
        // <summary>
        // Configuration used to send events to Amazon CloudWatch Logs.
        // </summary>
        [JsonProperty("cloudwatch_logs")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventTarget)obj;
            return (
                 this.Firehose == other.Firehose
                && this.Kinesis == other.Kinesis
                && this.CloudwatchLogs == other.CloudwatchLogs
            );
        }

    }
}
