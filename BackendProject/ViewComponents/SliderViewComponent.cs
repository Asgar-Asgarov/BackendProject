using BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;
using BackendProject.ViewModel;
using Microsoft.EntityFrameworkCore;

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
            homeVM.Sliders = _appDbContext.Sliders.Include(s=>s.SliderDetail).ToList();
           

            return View(await Task.FromResult(homeVM));
        }
    }
}