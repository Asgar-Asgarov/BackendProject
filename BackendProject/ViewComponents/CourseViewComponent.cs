using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendProject.DAL;
using BackendProject.ViewModel;

namespace BackendProject.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    { 
        private readonly AppDbContext _appDbContext;

        public CourseViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
          CourseVM courseVM = new CourseVM();
          courseVM.Courses=_appDbContext.courses.Take(3).ToList();
            return View(courseVM);
        }

    }
}
