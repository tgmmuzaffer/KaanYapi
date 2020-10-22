using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        public string _Name { get; set; }
        [Required]
        public string Barcode { get; set; }
        public decimal Price { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public bool IsNew { get; set; }
        public bool IsActive { get; set; }
    }
}
