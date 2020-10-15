using Newtonsoft.Json;
using SimpleMVCAppTest.Integration.Interfaces;
using SimpleMVCAppTest.Models;
using SimpleMVCAppTest.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Net;

namespace SimpleMVCAppTest.Integration
{
    public class RedList: IRedList
    {
        private readonly APISettingsConfiguration apiSettingsConfiguration;

        public RedList(APISettingsConfiguration apiSettingsConfiguration)
        {
            this.apiSettingsConfiguration = apiSettingsConfiguration;
        }

        public IEnumerable<Country> GetCountries()
        {
            var countries = DownloadAndDeserializeJsonData<JSONCountry>($"{apiSettingsConfiguration.CountryUrl}?token={apiSettingsConfiguration.PrivateKey}");
            return countries == null ? new List<Country>() : countries.Results;
        }   

        public IEnumerable<Animal> GetAnimalsByCountry(string countryCode)
        {
            var animals = DownloadAndDeserializeJsonData<JSONAnimal>($"{apiSettingsConfiguration.SpeciesUrl}/{countryCode}?token={apiSettingsConfiguration.PrivateKey}");
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
