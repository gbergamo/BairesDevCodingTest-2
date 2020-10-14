using System.Collections;
using System.Collections.Generic;

namespace SimpleMVCAppTest.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<AnimalViewModel> animals { get; set; }
        public IEnumerable<CountryViewModel> countries { get; set; }
    }
}
