using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() : base("apicon")
        {
        }
        public DbSet<Kullanici> Users { get; set; }
    }
}