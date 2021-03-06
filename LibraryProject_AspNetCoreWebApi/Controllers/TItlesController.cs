﻿using System;
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

        [HttpGet("GetById/{id}")]
        public ActionResult<Titles> Get(string id)
        {
            return Ok(_titlesService.GetTitle(id));
        }

        [HttpGet("GetByTitle")]
        public ActionResult<IEnumerable<TitlesByKeyword>> GetTitleByName()
        {
            return Ok(_titlesService.GetTitlesByName());
        }

        [HttpGet("GetByTitle/{titleName}")]
        public ActionResult<IEnumerable<TitlesByKeyword>> GetTitleByName(string titleName)
        {
            return Ok(_titlesService.GetTitlesByName(titleName));
        }

        [HttpGet("GetByAuthorName")]
        public ActionResult<IEnumerable<TitlesByKeyword>> GetTitleByAuthorName()
        {
            return Ok(_titlesService.GetTitlesByAuthorName());
        }

        [HttpGet("GetByAuthorName/{authorName}")]
        public ActionResult<IEnumerable<TitlesByKeyword>> GetTitlyByAuthorName(string authorName)
        {
            return Ok(_titlesService.GetTitlesByAuthorName(authorName));
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
