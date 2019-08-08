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
    public class AuthorsController : ControllerBase
    {
        private IAuthors _authorsService;
        public AuthorsController(IAuthors authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Authors>> Get()
        {
            return Ok(_authorsService.GetAuthors());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_authorsService.GetAuthor(id));
        }
    }
}
