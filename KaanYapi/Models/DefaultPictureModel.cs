using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class DefaultPictureModel
    {
        public int Id { get; set; }
        [Required]
        public string LittlePicturePath { get; set; }
        [Required]
        public string BigPicturePath { get; set; }
    }
}
