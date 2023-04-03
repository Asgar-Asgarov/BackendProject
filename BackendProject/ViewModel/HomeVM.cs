using BackendProject.Models;
using System.Collections.Generic;

namespace BackendProject.ViewModel
{
    public class HomeVM
    {
        public List<Slider>?  Sliders { get; set; }
        public SliderDetail? SliderDetail { get; set; }

    }
}
