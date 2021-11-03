using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab7b.Models
{
    public interface IPhoneRepository
    {
        Phone Add(Phone phone);
        Phone Get(int Id);
        List<Phone> GetAll();
        void Remove(int id);
        void Update(Phone phone);
        void Save(List<Phone> phones);
    }
}