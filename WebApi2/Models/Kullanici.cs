using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class Kullanici
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }
    }
}