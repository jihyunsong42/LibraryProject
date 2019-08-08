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

            // day 2 :Connected Database. Implemented AuthorsController
            // next step : install FluentAPI for multi-primary key
            // use postman to get a result of authorsSerivce.get()
      

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
