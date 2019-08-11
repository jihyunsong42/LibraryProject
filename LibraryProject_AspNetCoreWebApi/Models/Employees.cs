using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Employees
    {
        [Required, StringLength(9)]
        public string Emp_id { get; set; }

        [Required, StringLength(20)]
        public string Fname { get; set; }

        [Required, StringLength(1)]
        public string Minit { get; set; }

        [Required, StringLength(30)]
        public string Lname { get; set; }
        
        public short Job_id { get; set; }

        public byte? Job_lvl { get; set; }
        
        [Required, StringLength(4)]
        public string Pub_id { get; set; }

        public DateTime Hire_date { get; set; }

        // foreign key refers primary key, so Employee class has a dependency on Jobs class
        public virtual Jobs Job { get; set; }
        
        public virtual Publishers Publisher { get; set; }
    }
}
