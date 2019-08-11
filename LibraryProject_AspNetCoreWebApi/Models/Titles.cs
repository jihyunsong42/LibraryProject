using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class Titles
    {
        [Required, StringLength(6)]
        public string Title_id { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; }

        [Required, StringLength(12)]
        public string Type { get; set; }
        
        [Required, StringLength(4)]
        public string Pub_id { get; set; }

        public decimal? Price { get; set; }

        public decimal? Advance { get; set; }

        public int? Royalty { get; set; }

        public int? Ytd_sales { get; set; }

        [Required, StringLength(200)]
        public string Notes { get; set; }

        public DateTime Pubdate { get; set; }


        public virtual ICollection<Roysched> Royscheds { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }

        public virtual ICollection<Titleauthor> Titleauthors { get; set; }

        public virtual Publishers Publisher { get; set; }
    }
}
