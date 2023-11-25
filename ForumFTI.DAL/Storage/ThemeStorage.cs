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
    public class ThemeStorage : IBaseStorage<Theme>
    {
        public readonly ApplicationContext _db;

        public ThemeStorage(ApplicationContext db)
        {
            _db = db;
        }

        public async void Add(Theme item)
        {
            await _db.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async void Delete(Theme item)
        {
            _db.Remove(item);
            await _db.SaveChangesAsync();
        }

        public async Task<Theme> Get(Guid id)
        {
            return await _db.Themes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Theme>> GetAll()
        {
            return await _db.Themes.ToListAsync();
        }
    }
}
