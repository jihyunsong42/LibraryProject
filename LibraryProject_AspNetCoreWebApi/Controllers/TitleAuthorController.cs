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
    public class TitleauthorController : ControllerBase
    {
        private ITitleauthor _titleauthorService;
        public TitleauthorController(ITitleauthor titleauthorService)
        {
            _titleauthorService = titleauthorService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Titleauthor>> Get()
        {
            return Ok(_titleauthorService.GetTitleauthors());
        }

        [HttpGet("{au_id}/{title_id}")]
        public ActionResult<string> Get(string au_id, string title_id)
        {
            return Ok(_titleauthorService.GetTitleauthor(au_id, title_id));
        }

        [HttpPost]
        public void Post([FromBody] Titleauthor titleauthor)
        {
            _titleauthorService.AddTitleauthor(titleauthor);
        }

        [HttpPut("{au_id}/{title_id}")]
        public void Put(string au_id, string title_id, [FromBody]Titleauthor titleauthor)
        {
            _titleauthorService.UpdateTitleauthor(titleauthor);
        }

        [HttpDelete("{au_id}/{title_id}")]
        public void Delete(string au_id, string title_id)
        {
            _titleauthorService.DeleteTitleauthor(au_id, title_id);
        }
    }
}
