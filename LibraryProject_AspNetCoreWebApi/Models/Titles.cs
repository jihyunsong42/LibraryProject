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
        [Key]
        [Required, StringLength(6)]
        public string Title_id { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; }

        [Required, StringLength(12)]
        public string Type { get; set; }

        [ForeignKey("Publishers")]
        [Required, StringLength(4)]
        public string Pub_id { get; set; }

        public long? Price { get; set; }

        public long? Advance { get; set; }

        public int? Royalty { get; set; }

        public int? Ytd_sales { get; set; }

        [Required, StringLength(200)]
        public string Notes { get; set; }

        public DateTime Pubdate { get; set; }


        public virtual Roysched Roysched { get; set; }

        public virtual Sales Sales { get; set; }

        public virtual Titleauthor Titleauthor { get; set; }

        public virtual ICollection<Publishers> Publishers { get; set; }
    }
}
