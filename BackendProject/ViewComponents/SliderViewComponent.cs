using BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;
using BackendProject.ViewModel;

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
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _appDbContext.Sliders.ToList();

            return View(homeVM);
        }
    }
}