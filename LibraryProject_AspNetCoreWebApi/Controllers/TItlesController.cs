using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryProject_AspNetCoreWebApi.Models;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Services;

namespace LibraryProject_AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private ITitles _titlesService;
        public TitlesController(ITitles titlesService)
        {
            _titlesService = titlesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Titles>> Get()
        {
            return Ok(_titlesService.GetTitles());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_titlesService.GetTitle(id));
        }

        [HttpPost]
        public void Post([FromBody] Titles title)
        {
            _titlesService.AddTitle(title);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Titles title)
        {
            _titlesService.UpdateTitle(title);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _titlesService.DeleteTitle(id);
        }
    }
}
