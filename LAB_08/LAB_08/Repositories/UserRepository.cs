using LAB_08.DbContexts;
using LAB_08.Models;
using LAB_08.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_08.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext context;

        public UserRepository(UserDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public User Create(User phonebook)
        {
            return context.Users.Add(phonebook).Entity;
        }

        public User Update(User phonebook)
        {
            return context.Users.Update(phonebook).Entity;
        }

        public User Delete(int id)
        {
            User phonebook = context.Users.Find(id);
            if (phonebook != null)
            {
                return context.Users.Remove(phonebook).Entity;
            }

            return phonebook;
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
