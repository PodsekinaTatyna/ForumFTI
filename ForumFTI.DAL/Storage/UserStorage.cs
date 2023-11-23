using ForumFTI.DAL.Interfaces;
using ForumFTI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumFTI.DAL.Storage
{
    public class UserStorage : IBaseInteface<User>
    {
        public readonly ApplicationContext _db;

        public UserStorage(ApplicationContext db)
        {
            _db = db;
        }

        public async void Add(User item)
        {
            await _db.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async void Delete(User item)
        {
            _db.Remove(item);
            await _db.SaveChangesAsync();
        }

        public async Task<User> Get(Guid id)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }
    }
}
