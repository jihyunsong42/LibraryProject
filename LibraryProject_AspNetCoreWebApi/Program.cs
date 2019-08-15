using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using LibraryProject_AspNetCoreWebApi.Services;
using LibraryProject_AspNetCoreWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject_AspNetCoreWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            // day 1 : Objects and Relations Mapped
            // next step : http connection, solve CORS issues, connect to Database

            // day 2 : Connected Database. Implemented AuthorsController
            // next step : use FluentAPI for multi-primary key
            // use postman to get a result of authorsSerivce.get()

            // day 3 : multi-PK issue solved
            // faced with many different problems during call authorsService.get()
            // current issue : recursive problem(it happened while setting foreign key)
            // next step : fix the recursive issue, call authorsService.get()

            // day 4 : recursive issue solved
            // succeeded to call authorsService.get()
            // implemented get, post, put, delete, and successed call them
            // issues: an error occured when employee post is called.
            // its probably because of 'Employees' table name renaming.

            // day 5 : found the issue is because of SQL, not Entity Framework.
            // Implemented all controllers and validated its all functions.
            // issues : EmployeesController is still not working,(Put and Post)
            // issues 2 : Cannot call Get(id) in SalesController and Titleauthor(as those have a composite key)

            // day 6 : solved issue 1 by making new table.
            // issue 2 is solve by chaning id to title_id in http attribute.
            // Validated all functions of Controllers
            // started Front-End development
            // Implementing Stored Procedure
            // issues : Cannot call Stored Procedure : uspGetTitleByKeywordAsc from DbContext.

            // day 7 : solved an issue by using Microsoft.EntityFrameworkCore
            // issue : cannot return composite columns selected by Stored Procedure
            // I assume that it can't be returned to IQueryable<Titles> type, as it includes various different types.

            // day 8 : finally called Stored Procedure by creating new TitlesByKeyword Model
            // and save SELECT results in IQueryable<TitlesByKeyword>
            // Next step : develop Front-end Webpage.

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
