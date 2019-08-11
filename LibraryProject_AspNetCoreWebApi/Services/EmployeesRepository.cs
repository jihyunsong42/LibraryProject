using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Models;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public class EmployeesRepository : IEmployees
    {
        //Dependancy Injection
        private BookstoreDbContext bookstoreDbContext;
        public EmployeesRepository(BookstoreDbContext _bookstoreDbContext)
        {
            bookstoreDbContext = _bookstoreDbContext;
        }



        public IQueryable<Employees> GetEmployees()
        {
            return bookstoreDbContext.Employees;
        }

        public Employees GetEmployee(string id)
        {
            var employee = bookstoreDbContext.Employees.SingleOrDefault(i => i.Emp_id == id);
            return employee;
        }

        public void AddEmployee(Employees employee)
        {
            bookstoreDbContext.Add(employee);
            bookstoreDbContext.SaveChanges(true);
        }
        
        public void UpdateEmployee(Employees employee)
        {
            bookstoreDbContext.Update(employee);
            bookstoreDbContext.SaveChanges(true);
        }

        public void DeleteEmployee(string id)
        {
            var item = bookstoreDbContext.Employees.Find(id);
            bookstoreDbContext.Remove(item);
            bookstoreDbContext.SaveChanges(true);

        }


    }
}
