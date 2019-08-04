using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Titleauthor
    {
        [Key]
        [Required, StringLength(11)]
        public string Au_id { get; set; }

        [Key]
        [Required, StringLength(6)]
        public string Title_id { get; set; }

        public short? Au_ord { get; set; }

        public int? Royaltyper { get; set; }


        public virtual ICollection<Authors> Authors { get; set; }

        public virtual ICollection<Titles> Titles { get; set; }
    }
}
