using BackendProject.Models;
using System.Collections.Generic;

namespace BackendProject.ViewModel
{
    public class HomeVM
    {
        public List<Slider>?  Sliders { get; set; }
        public SliderDetail? SliderDetail { get; set; }
        public List<Notice>? Notices { get; set; }
        public Info? info { get; set; }
        public List<Thought>? thoughts { get; set; }

    }
}
