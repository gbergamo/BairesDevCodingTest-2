using AutoMapper;
using SimpleMVCAppTest.Models;
using SimpleMVCAppTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMVCAppTest.ApplicationService.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Country, CountryViewModel>();
            CreateMap<Animal, AnimalViewModel>();
        }
    }

}
