using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        public string _Name { get; set; }
        [Required]
        public string PicturePath { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [Required]
        public ProductModel Product { get; set; }
    }
}
