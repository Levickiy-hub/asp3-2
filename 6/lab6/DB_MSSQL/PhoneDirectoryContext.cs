using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DB_MSSQL
{
    class PhoneDirectoryContext : DbContext
    {
    {
        public PhoneDictionaryContext(string connString) : base($"name={connString}")
        {
        }

        public virtual DbSet<Phone> Phones { get; set; }
    }
}
