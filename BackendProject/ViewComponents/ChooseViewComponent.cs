using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class ChooseViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }

    }
}
