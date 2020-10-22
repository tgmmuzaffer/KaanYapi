using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string BlogHeader { get; set; }
        [Required]
        public string BlogBody { get; set; }
        [Required]
        public DateTime BlogDate { get; set; }
        public int ViewCount { get; set; }
    }
}
