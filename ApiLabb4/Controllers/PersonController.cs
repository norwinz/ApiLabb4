using ApiLabb4.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLabb4.Models;

namespace ApiLabb4.Controllers
{           //api/person/
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepo _repo;
        public PersonController(IPersonRepo repo)
        {
            _repo = repo;
        }
        [HttpGet("all")]
        public IActionResult GetAllPersons()
        {
            return Ok(_repo.GetAllPersons());
        }
        [HttpGet("{id}")]
        public IActionResult GetPersonById(int id)
        {
            var P = _repo.GetPersonById(id);
            if (P != null)
            {
                return Ok(P);
            }
            return NotFound("That user id does not exist in DB");
        }
        [HttpGet("ai/{id}")]    //api/person/ai/{id}    ai = "All Interest"
        public IActionResult AllInterest(int id)
        {
            return Ok(_repo.AllInterest(id));
        }
        [HttpGet("al/{id}")]    //api/person/al/{id}     al = "All Links"
        public IActionResult AllLinks(int id)
        {
            return Ok(_repo.AllLinks(id));
        }

    }
}

