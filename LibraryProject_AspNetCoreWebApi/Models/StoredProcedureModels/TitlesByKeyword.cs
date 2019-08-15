using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject_AspNetCoreWebApi.Models
{
    public class TitlesByKeyword
    {
        [Key]
        [Required, StringLength(6)]
        public string Title_id { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; }

        [Required, StringLength(40)]
        public string Au_lname { get; set; }

        [Required, StringLength(20)]
        public string Au_fname { get; set; }

        [Required, StringLength(40)]
        public string Pub_name { get; set; }

        public decimal? Price { get; set; }

        [Required, StringLength(200)]
        public string Notes { get; set; }

        public DateTime Pubdate { get; set; }
    }
}
