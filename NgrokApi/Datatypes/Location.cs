/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Location
    {
        // <summary>
        // ISO country code
        // </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        // <summary>
        // geographical latitude
        // </summary>
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }
        // <summary>
        // geographical longitude
        // </summary>
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
        // <summary>
        // accuracy radius of the geographical coordinates
        // </summary>
        [JsonProperty("lat_long_radius_km")]
        public int? LatLongRadiusKm { get; set; }

        public override string ToString()
        {
            return $"Location CountryCode={ CountryCode }  Latitude={ Latitude }  Longitude={ Longitude }  LatLongRadiusKm={ LatLongRadiusKm } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (CountryCode?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Latitude);
                hash = hash * 23 + Convert.ToInt32(Longitude);
                hash = hash * 23 + Convert.ToInt32(LatLongRadiusKm);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (Location)obj;
            return (
                 this.CountryCode == other.CountryCode
                && this.Latitude == other.Latitude
                && this.Longitude == other.Longitude
                && this.LatLongRadiusKm == other.LatLongRadiusKm
            );
        }

    }
}
