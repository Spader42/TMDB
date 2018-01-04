using Newtonsoft.Json;
using System;
using TMDB.Constants;

namespace TMDB.Objects
{
    public class Genre
    {
        [JsonProperty(PropertyName = GenreConstants.ID)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = GenreConstants.NAME)]
        public String Name { get; set; }
    }
}