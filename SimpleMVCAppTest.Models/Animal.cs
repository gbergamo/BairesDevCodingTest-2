using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMVCAppTest.Models
{
    public class Animal
    {
        [JsonProperty("taxonid")]
        public float TaxOnId { get; set; }

        [JsonProperty("scientific_name")]
        public string ScientificName { get; set; }

        [JsonProperty("subspecies")]
        public string Subspecies { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("subpopulation")]
        public string SubPopulation { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class JSONAnimal
    {
        //":null,"rank":null,"subpopulation":null,"category":"LC"},
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("result")]
        public IEnumerable<Animal> Result { get; set; }
    }
}
