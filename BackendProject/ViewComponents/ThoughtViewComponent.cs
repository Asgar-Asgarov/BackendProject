using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class ThoughtViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }
    }
}
