using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Pub_info
    {
        [Key]
        [ForeignKey("Publishers")]
        [Required, StringLength(4)]
        public string Pub_id { get; set; }
        
        public byte? Logo { get; set; }
       
        public string Pr_info { get; set; }


        public virtual ICollection<Publishers> Publishers { get; set; }
    }
}
