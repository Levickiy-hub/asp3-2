using lab7b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace lab7b.Service
{
    /// <summary>
    /// Сводное описание для PhoneDictionaryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class PhoneDictionaryService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        private string path = AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\db.json";

        IPhoneRepository repository;

        public PhoneDictionaryService()
        {
            repository = new PhoneRepository();
        }

        [WebMethod]
        public Phone Add(Phone phone)
        {
            return repository.Add(phone);
        }

        [WebMethod]
        public Phone Get(int id)
        {
            return repository.GetAll().Find(p => p.Id == id);
        }

        [WebMethod]
        public List<Phone> GetAll()
        {
            return repository.GetAll();
        }

        [WebMethod]
        public void Remove(int id)
        {
            repository.Remove(id);
        }

        [WebMethod]
        public void Update(Phone phone)
        {
            repository.Update(phone);
        }
    }
}
