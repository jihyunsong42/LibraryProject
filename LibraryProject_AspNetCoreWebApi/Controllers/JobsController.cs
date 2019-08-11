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
    public class JobsController : ControllerBase
    {
        private IJobs _jobService;
        public JobsController(IJobs jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Jobs>> Get()
        {
            return Ok(_jobService.GetJobs());
        }

        [HttpGet("{id}")]
        public ActionResult<short> Get(short id)
        {
            return Ok(_jobService.GetJob(id));
        }

        [HttpPost]
        public void Post([FromBody] Jobs job)
        {
            _jobService.AddJob(job);
        }

        [HttpPut("{id}")]
        public void Put(short id, [FromBody]Jobs job)
        {
            _jobService.UpdateJob(job);
        }

        [HttpDelete("{id}")]
        public void Delete(short id)
        {
            _jobService.DeleteJob(id);
        }
    }
}
