using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace lab7a.Models
{
    public class PhoneRepository : IPhoneRepository
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\db.json";


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

        public Phone Get(int Id)
        {
            return this.GetAll().Find(i => i.Id == Id);
        }

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

        public void Remove(int id)
        {
            List<Phone> phones = this.GetAll();

            Phone phoneDirectory = phones.Find(ph => ph.Id == id);
            phones.Remove(phoneDirectory);
            phones = phones.OrderBy(ph => ph.Name).ToList();
            Save(phones);
        }

        public void Update(Phone phone)
        {
            List<Phone> phones = this.GetAll();
            if (phone != null)
            {
                Phone upPhone = phones.Find(ph => ph.Id == phone.Id);
                upPhone.Name = phone.Name;
                upPhone.Phone_number = phone.Phone_number;
                Save(phones);
            }
        }

        public void Save(List<Phone> phones)
        {
            string json = JsonConvert.SerializeObject(phones);
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(json);
            }
        }
    }
}