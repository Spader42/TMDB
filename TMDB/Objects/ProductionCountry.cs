using Newtonsoft.Json;
using System;
using TMDB.Constants;

namespace TMDB.Objects
{
    public class ProductionCountry
    {
        [JsonProperty(PropertyName = ProductionCountryConstants.ISO3166_1)]
        public String Iso3166_1 { get; set; }

        [JsonProperty(PropertyName = ProductionCountryConstants.NAME)]
        public String Name { get; set; }
    }
}
