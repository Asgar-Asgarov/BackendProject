using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class EventViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }

    }
}
