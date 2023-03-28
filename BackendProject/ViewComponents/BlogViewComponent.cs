using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }
    }
}
