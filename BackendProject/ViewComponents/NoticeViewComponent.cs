using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class NoticeViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }
    }
}
