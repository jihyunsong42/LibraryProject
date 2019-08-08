using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IEmployee
    {
        IQueryable<Employee> GetEmployees();
        Employee GetEmployee(string id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(string id);
    }
}
