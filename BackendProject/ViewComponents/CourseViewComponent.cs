using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }

    }
}
