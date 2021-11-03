using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _04.Models
{
    public class PhoneService
    {
        private PhoneContext phoneContext;

        public PhoneService()
        {
            phoneContext = new PhoneContext();
        }

        public IEnumerable<Phone> GetAll()
        {
            return phoneContext.Phones;
        }

        public Phone Save(Phone phone)
        {
            phoneContext.Phones.Add(phone);
            phoneContext.SaveChanges();
            return phone;
        }

        public Phone GetById(int id)
        {
            return GetAll().ToList().Find(x=>x.PhoneId == id);
        }

        public Phone Update(Phone phone)
        {
            Phone result = phoneContext.Phones.FirstOrDefault(x=>x.PhoneId == phone.PhoneId);
            //result = phone;
            result.FirstName = phone.FirstName;
            result.LastName = phone.LastName;
            result.Number = phone.Number;
            phoneContext.SaveChanges();
            return result;
        }

        public Phone Delete(int id)
        {
            Phone phone = GetById(id);
            phoneContext.Phones.Remove(phone);
            phoneContext.SaveChanges();
            return phone;
        }

    }
}