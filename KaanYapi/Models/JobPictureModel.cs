using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Models
{
    public class JobPictureModel
    {
        public int Id { get; set; }
        public string _Name { get; set; }
        public string PicturePath { get; set; }
        [ForeignKey("JobId")]
        public int JobId { get; set; }
        public JobModel Job { get; set; }
    }
}
