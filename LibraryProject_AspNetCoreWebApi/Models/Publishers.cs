using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Publishers
    {
        [Required, StringLength(4)]
        public string Pub_id { get; set; }

        [Required, StringLength(40)]
        public string Pub_name { get; set; }

        [Required, StringLength(20)]
        public string City { get; set; }

        [Required, StringLength(2)]
        public string State { get; set; }

        [Required, StringLength(30)]
        public string Country { get; set; }
        
        public virtual ICollection<Employees> Employees { get; set; }

        public virtual ICollection<Pub_info> Pub_info { get; set; }

        public virtual ICollection<Titles> Titles { get; set; }
    }
}
