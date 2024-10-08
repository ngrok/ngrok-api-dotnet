/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventTargetAzureLogsIngestion
    {
        // <summary>
        // Tenant ID for the Azure account
        // </summary>
        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }
        // <summary>
        // Client ID for the application client
        // </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
        // <summary>
        // Client Secret for the application client
        // </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        // <summary>
        // Data collection endpoint logs ingestion URI
        // </summary>
        [JsonProperty("logs_ingestion_uri")]
        public string LogsIngestionUri { get; set; }
        // <summary>
        // Data collection rule immutable ID
        // </summary>
        [JsonProperty("data_collection_rule_id")]
        public string DataCollectionRuleId { get; set; }
        // <summary>
        // Data collection stream name to use as destination, located inside the DCR
        // </summary>
        [JsonProperty("data_collection_stream_name")]
        public string DataCollectionStreamName { get; set; }

        public override string ToString()
        {
            return $"EventTargetAzureLogsIngestion TenantId={ TenantId }  ClientId={ ClientId }  ClientSecret={ ClientSecret }  LogsIngestionUri={ LogsIngestionUri }  DataCollectionRuleId={ DataCollectionRuleId }  DataCollectionStreamName={ DataCollectionStreamName } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (TenantId?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClientId?.GetHashCode() ?? 0);

                hash = hash * 23 + (ClientSecret?.GetHashCode() ?? 0);

                hash = hash * 23 + (LogsIngestionUri?.GetHashCode() ?? 0);

                hash = hash * 23 + (DataCollectionRuleId?.GetHashCode() ?? 0);

                hash = hash * 23 + (DataCollectionStreamName?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventTargetAzureLogsIngestion)obj;
            return (
                 this.TenantId == other.TenantId
                && this.ClientId == other.ClientId
                && this.ClientSecret == other.ClientSecret
                && this.LogsIngestionUri == other.LogsIngestionUri
                && this.DataCollectionRuleId == other.DataCollectionRuleId
                && this.DataCollectionStreamName == other.DataCollectionStreamName
            );
        }

    }
}
