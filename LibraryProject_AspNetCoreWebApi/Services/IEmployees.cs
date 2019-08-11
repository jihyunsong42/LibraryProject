using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IEmployees
    {
        IQueryable<Employees> GetEmployees();
        Employees GetEmployee(string id);
        void AddEmployee(Employees employee);
        void UpdateEmployee(Employees employee);
        void DeleteEmployee(string id);
    }
}
