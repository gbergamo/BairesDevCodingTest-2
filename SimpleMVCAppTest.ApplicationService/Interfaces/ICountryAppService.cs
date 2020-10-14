using SimpleMVCAppTest.ViewModel;
using System.Collections.Generic;

namespace SimpleMVCAppTest.ApplicationService.Interfaces
{
    public interface ICountryAppService
    {
        IEnumerable<CountryViewModel> GetCountries();
    }
}
