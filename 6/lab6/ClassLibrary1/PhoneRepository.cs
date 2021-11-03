using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_MSSQL
{
    public class PhoneRepository : IPhoneDictionary<Phone>
    {
        public Phone Add(Phone phone)
        {
            if (phone != null)
            {
                using (PhoneDirectoryContext db = new PhoneDirectoryContext())
                {
                    db.Phones.Add(phone);
                    db.SaveChanges();
                    return phone;
                }
            }
            return null;
        }

        public List<Phone> GetAll()
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                List<Phone> phones = new List<Phone>();
                foreach (var item in db.Phones)
                {
                    phones.Add(item);
                }
                return phones;
            }
        }

        public Phone Get(int Id)
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                return db.Phones.Find(Id);
            }
        }


        public bool Remove(Phone phone)
        {
            using (PhoneDirectoryContext db = new PhoneDirectoryContext())
            {
                db.Phones.Remove(db.Phones.Find(phone.Id));
                db.SaveChanges();
            }
            return true;
        }

        public void save(List<Phone> phones)
        {
            throw new NotImplementedException();
        }

        public Phone Update(Phone phone)
        {
            if (phone != null)
            {
                using (PhoneDirectoryContext db = new PhoneDirectoryContext())
                {
                    Phone record = db.Phones.Find(phone.Id);
                    record.Name = phone.Name;
                    record.Phone_number = phone.Phone_number;
                    db.Entry(record).State = EntityState.Modified;
                    db.SaveChanges();
                    return phone;
                }
            }
            return null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
