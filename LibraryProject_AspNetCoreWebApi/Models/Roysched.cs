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
        public string FakeId { get; set;  }
        
        [Required, StringLength(6)]
        public string Title_id { get; set; }
            
        public int? Lorange { get; set; }

        public int? Hirange { get; set; }

        public int? Royalty { get; set; }


        public virtual Titles Title { get; set; }
    }
}
