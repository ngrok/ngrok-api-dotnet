/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class UserAgent
    {
        // <summary>
        // raw User-Agent request header
        // </summary>
        [JsonProperty("raw")]
        public string Raw { get; set; }
        // <summary>
        // browser name (e.g. Chrome)
        // </summary>
        [JsonProperty("browser_name")]
        public string BrowserName { get; set; }
        // <summary>
        // browser version (e.g. 102)
        // </summary>
        [JsonProperty("browser_version")]
        public string BrowserVersion { get; set; }
        // <summary>
        // type of device (e.g. Desktop)
        // </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }
        // <summary>
        // operating system name (e.g. MacOS)
        // </summary>
        [JsonProperty("os_name")]
        public string OsName { get; set; }
        // <summary>
        // operating system version (e.g. 10.15.7)
        // </summary>
        [JsonProperty("os_version")]
        public string OsVersion { get; set; }

        public override string ToString()
        {
            return $"UserAgent Raw={ Raw }  BrowserName={ BrowserName }  BrowserVersion={ BrowserVersion }  DeviceType={ DeviceType }  OsName={ OsName }  OsVersion={ OsVersion } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Raw?.GetHashCode() ?? 0);

                hash = hash * 23 + (BrowserName?.GetHashCode() ?? 0);

                hash = hash * 23 + (BrowserVersion?.GetHashCode() ?? 0);

                hash = hash * 23 + (DeviceType?.GetHashCode() ?? 0);

                hash = hash * 23 + (OsName?.GetHashCode() ?? 0);

                hash = hash * 23 + (OsVersion?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (UserAgent)obj;
            return (
                 this.Raw == other.Raw
                && this.BrowserName == other.BrowserName
                && this.BrowserVersion == other.BrowserVersion
                && this.DeviceType == other.DeviceType
                && this.OsName == other.OsName
                && this.OsVersion == other.OsVersion
            );
        }

    }
}
