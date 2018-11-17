using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Produces("application/json")]
    [Route("persons")]
    public class PersonController : Controller
    {
        private readonly AcmeDataContext _dbContext;

        public PersonController(AcmeDataContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult GetAllPersons()
        {
            return Ok(_dbContext.Persons);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetPersonById([FromRoute] int id)
        {
            Person person = _dbContext.Persons.SingleOrDefault(p => p.PersonId == id);
            if (person == null)
            {
                return NotFound("the person you are searching for appear that does not exist");
            }
            return Ok(person);
            
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdatePerson([FromRoute] int id, [FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("make sure that your model is the correct one");
            }

            _dbContext.Entry(person).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return Ok("Succesfull");
        }
        
        [HttpPost]
        public IActionResult AddPerson([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _dbContext.Add(person);
            _dbContext.SaveChanges();
            return Ok("Succesfully created a new person");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson([FromRoute] int id)
        {
            Person person = _dbContext.Persons.SingleOrDefault(p => p.PersonId == id);
            if (person == null)
            {
                return NotFound();
            }

            _dbContext.Persons.Remove(person);
            _dbContext.SaveChanges();
            return Ok("succesfully deleted");
        }
    }
}