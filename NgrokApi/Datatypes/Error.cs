/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    internal class Error
    {
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }
        [JsonProperty("msg")]
        public string Msg { get; set; }
        [JsonProperty("details")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
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
