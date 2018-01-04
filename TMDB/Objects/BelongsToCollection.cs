using Newtonsoft.Json;
using System;
using TMDB.Constants;

namespace TMDB.Objects
{
    public class BelongsToCollection
    {
        [JsonProperty(PropertyName = BelongsToCollectionConstants.ID)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = BelongsToCollectionConstants.NAME)]
        public String Name { get; set; }

        [JsonProperty(PropertyName = BelongsToCollectionConstants.POSTER_PATH)]
        public String PosterPath { get; set; }

        [JsonProperty(PropertyName = BelongsToCollectionConstants.BACKDROP_PATH)]
        public String BackdropPath { get; set; }
    }
}
