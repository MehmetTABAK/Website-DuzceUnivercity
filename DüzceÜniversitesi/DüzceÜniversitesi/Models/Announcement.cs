using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DüzceÜniversitesi.Models
{
    public class Announcement
    {
        [Key]
        public int ID { get; set; }
        public string DuyuruBasligi { get; set; }
        public string DuyuruIcerigi { get; set; }
    }
}
