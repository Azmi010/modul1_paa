using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using cobaapi.Models;
namespace cobaapi.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }

        [HttpGet("api/person/{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            PersonContext context = new PersonContext();
            Person person = context.GetPersonById(id);
            return Ok(person);
        }
    }
}
