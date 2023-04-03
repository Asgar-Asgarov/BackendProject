using Microsoft.AspNetCore.Mvc;
using BackendProject.DAL;
using BackendProject.ViewModel;

namespace BackendProject.ViewComponents
{
    public class ThoughtViewComponent:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public ThoughtViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.thoughts=_appDbContext.thought.ToList();

            return View(await Task.FromResult(homeVM));
        }
    }
}
