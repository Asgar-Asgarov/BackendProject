using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendProject.DAL;
using BackendProject.ViewModel;

namespace BackendProject.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public BlogViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           BlogVM blogVM = new BlogVM();
           blogVM.Blogs= _appDbContext.blog.Take(3).ToList();

            return View(await Task.FromResult(blogVM));
        }
    }
}
