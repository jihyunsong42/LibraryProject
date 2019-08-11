using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Jobs
    {
        public short Job_id { get; set; }
        
        [Required, StringLength(50)]
        public string Job_desc { get; set; }

        public byte Min_lvl { get; set; }
        public byte Max_lvl { get; set; }


        public virtual ICollection<Employees> Employees { get; set; }

    }
}
