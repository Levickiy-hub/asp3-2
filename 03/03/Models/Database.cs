using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace _03.Models
{
    public class Database
    {
        List<Data> database;
        public Database()
        {

        }

        public List<Data> GetAll()
        {
            this.database = JsonConvert.DeserializeObject<List<Data>>(File.ReadAllText(@"D:\\Trash\\3-2\\ASP\\03\03\\Data\\database.json", Encoding.GetEncoding(1251))).ToList();
            if(this.database.Count == 0)
            {
                this.database = new List<Data>();
            }
            return this.database.OrderBy(u => u.Name).ToList();
        }

        public Data Save(Data data)
        {
            int index = this.GetAll().Count;
            this.database.Insert(index,data);
            data.Id = index+1;
            File.WriteAllText(@"D:\\Trash\\3-2\\ASP\\03\03\\Data\\database.json", JsonConvert.SerializeObject(this.database), Encoding.GetEncoding(1251));
            return data;
        }

        public Data Update(Data data)
        {
            this.database = this.GetAll();
            int index = this.database.IndexOf(this.database.Find(x => x.Id == data.Id));
            this.database[index] = data;
            File.WriteAllText(@"D:\\Trash\\3-2\\ASP\\03\03\\Data\\database.json", JsonConvert.SerializeObject(this.database), Encoding.GetEncoding(1251));
            return data;
        }

        public Data FindById(int id) {
            return this.GetAll().Find(x => x.Id == id);
        }

        public Data Delete(int id)
        {
            this.database = this.GetAll();
            Data deleted = this.database.Where(x => x.Id == id).First();
            this.database = this.database.Where(x => x.Id != id).ToList();
            File.WriteAllText(@"D:\\Trash\\3-2\\ASP\\03\03\\Data\\database.json", JsonConvert.SerializeObject(this.database), Encoding.GetEncoding(1251));
            return deleted;
        }
    }

    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }

        public Data(int id, string name, long phone)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
        }

        public Data()
        {

        }
    }
}