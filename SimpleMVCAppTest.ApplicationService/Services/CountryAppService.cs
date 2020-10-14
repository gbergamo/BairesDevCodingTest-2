using AutoMapper;
using SimpleMVCAppTest.ApplicationService.Interfaces;
using SimpleMVCAppTest.Integration.Interfaces;
using SimpleMVCAppTest.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace SimpleMVCAppTest.ApplicationService.Services
{
    public class CountryAppService : ICountryAppService
    {
        private readonly IRedList redList;
        private readonly IMapper mapper;

        public CountryAppService(IRedList redList, IMapper mapper)
        {
            this.redList = redList;
            this.mapper = mapper;
        }
        public IEnumerable<CountryViewModel> GetCountries()
        {
            var svcContries = redList.GetCountries();
            var countryViewModel = mapper.Map<IEnumerable<CountryViewModel>>(svcContries);
            return countryViewModel.OrderBy(x => x.Name).ToList();
        }
    }
}
