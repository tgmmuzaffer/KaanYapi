using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class SubCategoryModel
    {
        public int Id { get; set; }
        [Required]
        public string _Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public CategoryModel Categories { get; set; }
    }
}
