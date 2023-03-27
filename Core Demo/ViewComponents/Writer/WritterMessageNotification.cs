using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Writer
{
    public class WritterMessageNotification : ViewComponent
    {

        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "haticezehraorhan@gmail.com";
            var values = messageManager.GetInboxListByWritter(p);
            return View(values);

        }


    }
}
