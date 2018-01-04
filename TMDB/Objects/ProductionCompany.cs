using Newtonsoft.Json;
using System;
using TMDB.Constants;

namespace TMDB.Objects
{
    public class ProductionCompany
    {
        [JsonProperty(PropertyName = ProductionCompanyConstants.ID)]
        public String Name { get; set; }

        [JsonProperty(PropertyName = ProductionCompanyConstants.NAME)]
        public String Id { get; set; }
    }
}
