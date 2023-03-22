using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Writer
{
    public class WritterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
