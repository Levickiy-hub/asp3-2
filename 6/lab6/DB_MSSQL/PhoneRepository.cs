using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PhoneDictionary;

namespace DB_MSSQL
{
    public class PhoneDirectoryRepository : IPhoneDictionary<Phone>
    {
        public void create(PhoneDirectoryRecord phone)
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                db.PhoneDirectoryRecords.Add(phone);
                db.SaveChanges();
            }
        }

        public List<PhoneDirectoryRecord> getAll()
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                List<PhoneDirectoryRecord> phones = new List<PhoneDirectoryRecord>();
                foreach (var item in db.PhoneDirectoryRecords)
                {
                    phones.Add(item);
                }
                return phones;
            }
        }

        public PhoneDirectoryRecord getById(int Id)
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                return db.PhoneDirectoryRecords.Find(Id);
            }
        }


        public void remove(PhoneDirectoryRecord phone)
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                db.PhoneDirectoryRecords.Remove(db.PhoneDirectoryRecords.Find(phone.Id));
                db.SaveChanges();
            }
        }

        public void save(List<PhoneDirectoryRecord> phones)
        {
            throw new NotImplementedException();
        }

        public void Update(PhoneDirectoryRecord phone)
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                PhoneDirectoryRecord record = db.PhoneDirectoryRecords.Find(phone.Id);
                record.Name = phone.Name;
                record.Phone = phone.Phone;
                db.Entry(record).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
