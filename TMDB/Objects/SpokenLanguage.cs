using Newtonsoft.Json;
using System;
using TMDB.Constants;

namespace TMDB.Objects
{
    public class SpokenLanguage
    {
        [JsonProperty(PropertyName = SpokenLanguagesConstants.ISO639_1)]
        public String Iso639_1 { get; set; }

        [JsonProperty(PropertyName = SpokenLanguagesConstants.NAME)]
        public String Name { get; set; }
    }
}
