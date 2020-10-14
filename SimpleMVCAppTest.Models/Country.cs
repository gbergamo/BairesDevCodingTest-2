using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMVCAppTest.Models
{
    public class Country
    {
        [JsonProperty("isocode")]
        public string IsoCode { get; set; }
        
        [JsonProperty("country")]
        public string Name { get; set; }
    }

    public class JSONCountry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public IEnumerable<Country> Results { get; set; }
    }
}
