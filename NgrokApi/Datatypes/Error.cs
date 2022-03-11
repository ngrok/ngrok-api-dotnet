
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    internal class Error
    {
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }
        [JsonPropertyName("msg")]
        public string Msg { get; set; }
        [JsonPropertyName("details")]
        public Dictionary<string, string> Details { get; set; }

        public override string ToString()
        {
            return $"Error ErrorCode={ ErrorCode }  StatusCode={ StatusCode }  Msg={ Msg }  Details={ Details } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ErrorCode?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(StatusCode);
                hash = hash * 23 + (Msg?.GetHashCode() ?? 0);

                hash = hash * 23 + (Details?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (Error)obj;
            return (
                 this.ErrorCode == other.ErrorCode
                && this.StatusCode == other.StatusCode
                && this.Msg == other.Msg
                && this.Details == other.Details
            );
        }

    }
}
