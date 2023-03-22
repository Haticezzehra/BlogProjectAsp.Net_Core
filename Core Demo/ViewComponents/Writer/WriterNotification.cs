using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
