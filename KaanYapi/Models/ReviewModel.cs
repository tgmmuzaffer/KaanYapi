using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Star { get; set; }
        [Required]
        public string ContentOwner { get; set; }
        [Required]
        public bool IsOk { get; set; }
        [Required]
        public string EMail { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public BlogModel Blog { get; set; }
    }
}
