using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDB.Client
{
    public class TMDBClient
    {
        private String ApiVersion;
        private String BaseURL;

        private readonly JsonSerializer Serializer;
    }
}