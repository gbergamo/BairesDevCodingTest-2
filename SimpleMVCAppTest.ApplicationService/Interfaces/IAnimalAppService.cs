using SimpleMVCAppTest.ViewModel;
using System.Collections.Generic;

namespace SimpleMVCAppTest.ApplicationService.Interfaces
{
    public interface IAnimalAppService
    {
        IEnumerable<AnimalViewModel> GetAnimalByCountryCode(string countryCode);
    }
}
