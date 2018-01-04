using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TMDB.Constants;

namespace TMDB.Objects
{
    public class Movie
    {
        [JsonProperty(PropertyName = MovieConstants.ADULT)]
        public Boolean Adult { get; set; }

        [JsonProperty(PropertyName = MovieConstants.BACKDROP_PATH)]
        public String BackdropPath { get; set; }

        [JsonProperty(PropertyName = MovieConstants.BELONGS_TO_COLLECTION)]
        public BelongsToCollection BelongsToCollection { get; set; }

        [JsonProperty(PropertyName = MovieConstants.BUDGET)]
        public long Budget { get; set; }

        [JsonProperty(PropertyName = MovieConstants.GENRES)]
        public List<Genre> Genres { get; set; }

        [JsonProperty(PropertyName = MovieConstants.HOMEPAGE)]
        public String Homepage { get; set; }

        [JsonProperty(PropertyName = MovieConstants.ID)]
        public long Id { get; set; }

        [JsonProperty(PropertyName = MovieConstants.IMDB_ID)]
        public String ImdbId { get; set; }

        [JsonProperty(PropertyName = MovieConstants.ORIGINAL_LANGUAGE)]
        public String OriginalLanguage { get; set; }

        [JsonProperty(PropertyName = MovieConstants.ORIGINAL_TITLE)]
        public String OriginalTitle { get; set; }

        [JsonProperty(PropertyName = MovieConstants.OVERVIEW)]
        public String Overview { get; set; }

        [JsonProperty(PropertyName = MovieConstants.POPULARITY)]
        public float Popularity { get; set; }

        [JsonProperty(PropertyName = MovieConstants.POSTER_PATH)]
        public String PosterPath { get; set; }

        [JsonProperty(PropertyName = MovieConstants.PRODUCTION_COMPANIES)]
        public List<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty(PropertyName = MovieConstants.PRODUCTION_COUNTRIES)]
        public List<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty(PropertyName = MovieConstants.RELEASE_DATE)]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty(PropertyName = MovieConstants.REVENUE)]
        public long Revenue { get; set; }

        [JsonProperty(PropertyName = MovieConstants.RUNTIME)]
        public int Runtime { get; set; }

        [JsonProperty(PropertyName = MovieConstants.SPOKEN_LANGUAGES)]
        public List<SpokenLanguage> SpokenLanguages { get; set; }

        [JsonProperty(PropertyName = MovieConstants.STATUS)]
        public String Statuts { get; set; }

        [JsonProperty(PropertyName = MovieConstants.TAGLINE)]
        public String Tagline { get; set; }

        [JsonProperty(PropertyName = MovieConstants.TITLE)]
        public String Title { get; set; }

        [JsonProperty(PropertyName = MovieConstants.VIDEO)]
        public Boolean Video { get; set; }

        [JsonProperty(PropertyName = MovieConstants.VOTE_AVERAGE)]
        public float VoteAverage { get; set; }

        [JsonProperty(PropertyName = MovieConstants.VOTE_COUNT)]
        public long VoteCount { get; set; }
    }
}
