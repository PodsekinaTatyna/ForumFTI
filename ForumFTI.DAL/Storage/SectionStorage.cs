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
    public class SectionStorage : IBaseStorage<Section>
    {

        public readonly ApplicationContext _db;

        public SectionStorage(ApplicationContext db)
        {
            _db = db;
        }
        
        public async void Add(Section item)
        {
            await _db.AddAsync(item);
            await _db.SaveChangesAsync();

        }

        public async void Delete(Section item)
        {
            _db.Remove(item);
            await _db.SaveChangesAsync();
        }

        public async Task<Section> Get(Guid id)
        {
            return await _db.Sections.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Section>> GetAll()
        {
            return await _db.Sections.ToListAsync();
        }
    }
}
