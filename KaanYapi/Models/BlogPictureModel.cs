using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class BlogPictureModel
    {
        public int Id { get; set; }
        [Required]
        public string _Name { get; set; }
        [Required]
        public string PicturePath { get; set; }
        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public BlogModel Blog { get; set; }
    }
}
