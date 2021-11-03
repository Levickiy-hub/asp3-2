using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _04.Models
{
    public class PhoneContext: DbContext
    {
        public PhoneContext() : base("PhoneContext") { }
        public DbSet<Phone> Phones { get; set; }
    }
}