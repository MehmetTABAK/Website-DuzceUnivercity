using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DüzceÜniversitesi.Models
{
    public class User
    {
        [Key]
        public int adminID { get; set; }

        public string email { get; set; }

        public string sifre { get; set; }
    }
}
