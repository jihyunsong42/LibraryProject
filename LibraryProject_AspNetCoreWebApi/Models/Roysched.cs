using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Roysched
    {
        [Key]
        public string FakeId { get; set;  }

        [ForeignKey("Titles")]
        [Required, StringLength(6)]
        public string Title_id { get; set; }
            
        public int? Lorange { get; set; }

        public int? Hirange { get; set; }

        public int? Royalty { get; set; }


        public virtual ICollection<Titles> Titles { get; set; }
    }
}
