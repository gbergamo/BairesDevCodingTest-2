using AutoMapper;
using SimpleMVCAppTest.ApplicationService.Interfaces;
using SimpleMVCAppTest.Integration.Interfaces;
using SimpleMVCAppTest.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace SimpleMVCAppTest.ApplicationService.Services
{
    public class AnimalAppService : IAnimalAppService
    {
        private readonly IRedList redList;
        private readonly IMapper mapper;

        public AnimalAppService(IRedList redList, IMapper mapper)
        {
            this.redList = redList;
            this.mapper = mapper;
        }

        public IEnumerable<AnimalViewModel> GetAnimalByCountryCode(string countryCode)
        {
            var svcAnimal = redList.GetAnimalsByCountry(countryCode);
            var animalViewModel = mapper.Map<List<AnimalViewModel>>(svcAnimal);
            return animalViewModel.OrderBy(x => x.ScientificName).ToList();
        }
    }
}
