using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Stores
    {
        [Key]
        [Required, StringLength(4)]
        public string Stor_id { get; set; }

        [Required, StringLength(40)]
        public string Stor_name { get; set; }

        [Required, StringLength(40)]
        public string Stor_address { get; set; }

        [Required, StringLength(20)]
        public string City { get; set; }

        [Required, StringLength(2)]
        public string State { get; set; }

        [Required, StringLength(5)]
        public string Zip { get; set; }


        public virtual Discounts Discounts { get; set; }

        public virtual Sales Sales { get; set; }

        
    }
    
}
