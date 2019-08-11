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
    public class EmployeesController : ControllerBase
    {
        private IEmployees _employeesService;
        public EmployeesController(IEmployees employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employees>> Get()
        {
            return Ok(_employeesService.GetEmployees());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_employeesService.GetEmployee(id));
        }


        [HttpPost]
        public void Post([FromBody] Employees employee)
        {
            _employeesService.AddEmployee(employee);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Employees employee)
        {
            _employeesService.UpdateEmployee(employee);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _employeesService.DeleteEmployee(id);
        }
    }
}
