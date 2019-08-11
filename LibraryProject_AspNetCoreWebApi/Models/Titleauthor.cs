using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Titleauthor
    {
        [Required, StringLength(11)]
        public string Au_id { get; set; }
        
        [Required, StringLength(6)]
        public string Title_id { get; set; }

        public byte? Au_ord { get; set; }

        public int? Royaltyper { get; set; }


        public virtual Authors Author { get; set; }

        public virtual Titles Title { get; set; }
    }
}
