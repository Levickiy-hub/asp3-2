using LAB_08.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LAB_08.SeedWork
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> Get(int id);
        User Create(User phonebook);
        User Update(User phonebook);
        User Delete(int id);
        Task SaveChanges();
    }
}
