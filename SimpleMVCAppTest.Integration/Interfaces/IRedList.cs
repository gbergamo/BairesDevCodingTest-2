using SimpleMVCAppTest.Models;
using System.Collections.Generic;

namespace SimpleMVCAppTest.Integration.Interfaces
{
    public interface IRedList
    {
        IEnumerable<Country> GetCountries();
        IEnumerable<Animal> GetAnimalsByCountry(string countryCode);
    }
}
