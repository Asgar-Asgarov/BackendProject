using BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public SliderViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = _appDbContext.Sliders.ToList();

            return View(sliders);
        }
    }
}