using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_MSSQL
{
    class PhoneDirectoryContext : DbContext
    {

        public PhoneDirectoryContext()
        : base("DbConnection")
        { }

        public virtual DbSet<Phone> Phones { get; set; }
    }
}
