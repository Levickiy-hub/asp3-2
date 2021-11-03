using lab7a.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;

namespace lab7a.Controllers
{
    public class TSController : ApiController
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\db.json";

        IPhoneRepository repository;

        public TSController()
        {
            repository = new PhoneRepository();
        }

        [HttpPost]
        public Phone Add([FromBody] Phone phone)
        {
            return repository.Add(phone);
        }

        [HttpGet]
        public Phone Get(int id)
        {
            return repository.GetAll().Find(p=> p.Id == id);
        }

        [HttpGet]
        public List<Phone> GetAll()
        {
            return repository.GetAll();
        }

        [HttpDelete]
        public void Remove([FromUri] int id)
        {
            repository.Remove(id);
        }

        [HttpPut]
        public void Update([FromBody] Phone phone)
        {
            repository.Update(phone);
        }
    }
}