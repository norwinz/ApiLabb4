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
    public class WebSiteController : ControllerBase
    {
        private IWebSiteRepo _repo;
        public WebSiteController(IWebSiteRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public void AddWebSite([FromBody] WebSite newWebSite)
        {
            _repo.AddWebSite(newWebSite);
        }
    }
}
