using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApiDemo.Controllers
{
    //Api Controller
    [Route("api/[controller]")]  //bir web projesinden çağırmak istersek bu yolu yazıyoruz
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet] //Veri getireceğimiz kısım.
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Emplooyees.ToList();
            return Ok(values); //Ok başarılı durum kodu demek.
        }
    }
}
