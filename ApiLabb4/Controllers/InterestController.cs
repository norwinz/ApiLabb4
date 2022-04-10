using ApiLabb4.Data;
using ApiLabb4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private IInterestRepo _repo;
        public InterestController(IInterestRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public void AddInterest([FromBody]Interest newInterest)
        {
            _repo.AddInterest(newInterest);
        }
    }
}
