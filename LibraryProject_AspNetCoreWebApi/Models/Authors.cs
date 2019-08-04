using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Authors
    {
        [Key]
        [Required, StringLength(11)]
        public string Au_id { get; set; }

        [Required, StringLength(40)]
        public string Au_lname { get; set; }

        [Required, StringLength(20)]
        public string Au_fname { get; set; }

        [Required, StringLength(12)]
        public string Phone { get; set; }

        [Required, StringLength(40)]
        public string Address { get; set; }

        [Required, StringLength(20)]
        public string City { get; set; }

        [Required, StringLength(2)]
        public string State { get; set; }

        [Required, StringLength(5)]
        public string Zip { get; set; }

        public bool Contract { get; set; }


        public virtual Titleauthor Titleauthor { get; set; }
    }
}
