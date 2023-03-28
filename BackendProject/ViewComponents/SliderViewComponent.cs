using BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }
    }
}