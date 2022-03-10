
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class HttpResponseBackend : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the HTTPResponseBackend API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the backend was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this backend. Optional
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this backend. Optional
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // body to return as fixed content
        // </summary>
        [JsonProperty("body")]
        public string Body { get; set; }
        // <summary>
        // headers to return
        // </summary>
        [JsonProperty("headers")]
        public Dictionary<string, string> Headers { get; set; }
        // <summary>
        // status code to return
        // </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        public override string ToString()
        {
            return $"HttpResponseBackend Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Body={ Body }  Headers={ Headers }  StatusCode={ StatusCode } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Body?.GetHashCode() ?? 0);

                hash = hash * 23 + (Headers?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(StatusCode);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (HttpResponseBackend)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Body == other.Body
                && this.Headers == other.Headers
                && this.StatusCode == other.StatusCode
            );
        }

    }
}
