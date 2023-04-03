using Microsoft.AspNetCore.Mvc;
using BackendProject.DAL;
using BackendProject.ViewModel;

namespace BackendProject.ViewComponents
{
    public class ChooseViewComponent: ViewComponent
    {
             private readonly AppDbContext _appDbContext;

        public ChooseViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           HomeVM homeVM = new HomeVM();
           homeVM.info=_appDbContext.info.FirstOrDefault();
            return View(await Task.FromResult(homeVM));
        }

    }
}
