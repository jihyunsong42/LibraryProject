using LibraryProject_AspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Services
{
    public interface IPub_info
    {
        IQueryable<Pub_info> GetPub_infos();
        Pub_info GetPub_info(string id);
        void AddPub_info(Pub_info pub_info);
        void UpdatePub_info(Pub_info pub_info);
        void DeletePub_info(string id);
    }
}
