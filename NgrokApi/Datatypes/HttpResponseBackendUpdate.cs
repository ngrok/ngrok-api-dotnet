/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class HttpResponseBackendUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        public int? StatusCode { get; set; }

        public override string ToString()
        {
            return $"HttpResponseBackendUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  Body={ Body }  Headers={ Headers }  StatusCode={ StatusCode } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (HttpResponseBackendUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Body == other.Body
                && this.Headers == other.Headers
                && this.StatusCode == other.StatusCode
            );
        }

    }
}
