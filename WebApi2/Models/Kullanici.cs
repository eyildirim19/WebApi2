using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class Kullanici
    {
        public int ID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Sifre { get; set; }
    }
}