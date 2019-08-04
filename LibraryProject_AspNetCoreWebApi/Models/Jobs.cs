using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Jobs
    {
        [Key]
        public short Job_id { get; set; }
        
        [Required, StringLength(50)]
        public string Job_desc { get; set; }

        public short Min_lvl { get; set; }
        public short Max_lvl { get; set; }


        public virtual Employee Employee { get; set; }

    }
}
