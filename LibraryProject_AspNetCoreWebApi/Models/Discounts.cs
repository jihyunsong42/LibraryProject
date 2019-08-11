using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Discounts
    {
        public string fakeId { get; set; }

        [Required, StringLength(40)]
        public string Discounttype { get; set; }
        
        [Required, StringLength(4)]
        public string Stor_id { get; set; }

        public short? Lowqty { get; set; }

        public short? Highqty { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999.99)]
        public decimal Discount { get; set; }
        
        public virtual Stores Store { get; set; }

    }
}
