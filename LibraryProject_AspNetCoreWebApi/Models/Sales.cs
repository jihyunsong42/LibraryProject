using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Sales
    {
        [Required, StringLength(4)]
        public string Stor_id { get; set; }

        [Required, StringLength(20)]
        public string Ord_num { get; set; }

        public DateTime Ord_date { get; set; }

        public short Qty { get; set; }

        [Required, StringLength(12)]
        public string Payterms { get; set; }
        
        [Required, StringLength(6)]
        public string Title_id { get; set; }


        public virtual Stores Store { get; set; }

        public virtual Titles Title { get; set; }
    }
}
