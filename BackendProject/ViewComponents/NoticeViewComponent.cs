using Microsoft.AspNetCore.Mvc;
using BackendProject.DAL;
using BackendProject.ViewModel;

namespace BackendProject.ViewComponents
{
    public class NoticeViewComponent:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public NoticeViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
        HomeVM homeVM = new HomeVM();
         homeVM.Notices=_appDbContext.Notices.ToList();

            return View(await Task.FromResult(homeVM));
        }
    }
}
