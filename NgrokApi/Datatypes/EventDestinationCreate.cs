using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventDestinationCreate
    {
        // <summary>
        // Arbitrary user-defined machine-readable data of this Event Destination.
        // Optional, max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Human-readable description of the Event Destination. Optional, max 255 bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // The output format you would like to serialize events into when sending to their
        // target. Currently the only accepted value is <c>JSON</c>.
        // </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }
        // <summary>
        // An object that encapsulates where and how to send your events. An event
        // destination must contain exactly one of the following objects, leaving the rest
        // null: <c>kinesis</c>, <c>firehose</c>, <c>cloudwatch_logs</c>, or <c>s3</c>.
        // </summary>
        [JsonPropertyName("target")]
        public EventTarget Target { get; set; }

        public override string ToString()
        {
            return $"EventDestinationCreate Metadata={ Metadata }  Description={ Description }  Format={ Format }  Target={ Target } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Format?.GetHashCode() ?? 0);

                hash = hash * 23 + (Target?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventDestinationCreate)obj;
            return (
                 this.Metadata == other.Metadata
                && this.Description == other.Description
                && this.Format == other.Format
                && this.Target == other.Target
            );
        }

    }
}
