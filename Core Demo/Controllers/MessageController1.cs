using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Core_Demo.Controllers
{
    [AllowAnonymous]
    public class MessageController1 : Controller
    {
        Message2Manager messsageManager = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = messsageManager.GetInboxListByWritter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = messsageManager.GetById(id);

            return View(value);
        }
    }
}
