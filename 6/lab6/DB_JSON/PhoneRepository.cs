using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using PhoneDictionary;

namespace DB_JSON
{
    public class PhoneRepository : IPhoneDictionary<Phone>
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\db.json";

        public List<Phone> GetAll()
        {
            List<Phone> phones = new List<Phone>();
            using (StreamReader sr = new StreamReader(path))
            {
                string info = sr.ReadToEnd();
                phones = JsonConvert.DeserializeObject<List<Phone>>(info).ToList();
            }
            return phones;
        }

        public Phone Add(Phone phone)
        {
            if (phone != null)
            {
                List<Phone> phones = this.GetAll();
                if (!phones.Any(ph => ph.Name == phone.Name))
                {
                    var id = phones.Count + 1;
                    phones.Add(new Phone { Id = id, Name = phone.Name, Phone_number = phone.Phone_number });
                    phones = phones.OrderBy(ph => ph.Name).ToList();
                    Save(phones);
                    return phone;
                }
            }
            return null;
        }

        public bool Remove(Phone phone)
        {
            List<Phone> phones = this.GetAll();
            if (phone != null)
            {
                Phone phoneDirectory = phones.Find(ph => ph.Id == phone.Id);
                phones.Remove(phoneDirectory);
                phones = phones.OrderBy(ph => ph.Name).ToList();
                Save(phones);
            }
            return true;
        }
        public Phone Get(int Id)
        {
            return this.GetAll().Find(i => i.Id == Id);
        }
        public Phone Update(Phone phone)
        {
            List<Phone> phones = this.GetAll();
            if (phone != null)
            {
                Phone upPhone = phones.Find(ph => ph.Id == phone.Id);
                upPhone.Name = phone.Name;
                upPhone.Phone_number = phone.Phone_number;
                Save(phones);
                return upPhone;
            }
            return null;
        }

        public void Save(List<Phone> phones)
        {
            string json = JsonConvert.SerializeObject(phones);
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(json);
            }
        }

        public void Dispose() { }
    }
}
