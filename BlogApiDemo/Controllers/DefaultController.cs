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
            using var c = new Contexxt();
            var values = c.Emplooyees.ToList();
            return Ok(values); //Ok başarılı durum kodu demek.
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new Contexxt();
            var values = c.Emplooyees.Add(employee);
            c.SaveChanges();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            using var c = new Contexxt();
            var values = c.Emplooyees.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            using var c = new Contexxt();
            var employee = c.Emplooyees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            using var c = new Contexxt();
            var emp = c.Find<Employee>(employee.ID);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employee.Name;
                c.SaveChanges();
                return Ok();
            }

        }
    }
}
