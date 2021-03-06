﻿using Newtonsoft.Json;

namespace QuizUpHack.Models
{
    public partial class Location
    {
        [JsonProperty("city_name")]
        public object CityName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }
    }
}