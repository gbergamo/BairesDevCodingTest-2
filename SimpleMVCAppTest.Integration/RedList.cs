using Newtonsoft.Json;
using SimpleMVCAppTest.Integration.Interfaces;
using SimpleMVCAppTest.Models;
using System;
using System.Collections.Generic;
using System.Net;

namespace SimpleMVCAppTest.Integration
{
    public class RedList: IRedList
    {
        private const string PRIVATEKEY = "9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee";
        private const string COUNTRY_URL = "http://apiv3.iucnredlist.org/api/v3/country/list";
        private const string ANIMAL_URL = "http://apiv3.iucnredlist.org/api/v3/country/getspecies";

        public IEnumerable<Country> GetCountries()
        {
            var countries = DownloadAndDeserializeJsonData<JSONCountry>($"{COUNTRY_URL}?token={PRIVATEKEY}");
            return countries == null ? new List<Country>() : countries.Results;
        }   

        public IEnumerable<Animal> GetAnimalsByCountry(string countryCode)
        {
            var animals = DownloadAndDeserializeJsonData<JSONAnimal>($"{ANIMAL_URL}/{countryCode}?token={PRIVATEKEY}");
            return animals == null ? new List<Animal>() : animals.Result;
        }

        private static T DownloadAndDeserializeJsonData<T>(string url) where T : new()
        {
            using (var webClient = new WebClient())
            {
                var jsonData = string.Empty;
                try
                {
                    jsonData = webClient.DownloadString(url);
                    return JsonConvert.DeserializeObject<T>(jsonData);
                }   
                catch (Exception ex) 
                { 
                    // TODO: Log error
                }

                return default(T);
            }
        }


    }
}
