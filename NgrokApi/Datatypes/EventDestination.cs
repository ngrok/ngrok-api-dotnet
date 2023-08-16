/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventDestination : HasId
    {
        // <summary>
        // Unique identifier for this Event Destination.
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // Arbitrary user-defined machine-readable data of this Event Destination.
        // Optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Timestamp when the Event Destination was created, RFC 3339 format.
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // Human-readable description of the Event Destination. Optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // The output format you would like to serialize events into when sending to their
        // target. Currently the only accepted value is <c>JSON</c>.
        // </summary>
        [JsonProperty("format")]
        public string Format { get; set; }
        // <summary>
        // An object that encapsulates where and how to send your events. An event
        // destination must contain exactly one of the following objects, leaving the rest
        // null: <c>kinesis</c>, <c>firehose</c>, <c>cloudwatch_logs</c>, or <c>s3</c>.
        // </summary>
        [JsonProperty("target")]
        public EventTarget Target { get; set; }
        // <summary>
        // URI of the Event Destination API resource.
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        public override string ToString()
        {
            return $"EventDestination Id={ Id }  Metadata={ Metadata }  CreatedAt={ CreatedAt }  Description={ Description }  Format={ Format }  Target={ Target }  Uri={ Uri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Format?.GetHashCode() ?? 0);

                hash = hash * 23 + (Target?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventDestination)obj;
            return (
                 this.Id == other.Id
                && this.Metadata == other.Metadata
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Format == other.Format
                && this.Target == other.Target
                && this.Uri == other.Uri
            );
        }

    }
}
