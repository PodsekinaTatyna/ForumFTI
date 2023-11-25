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
    public class QuestionStorage : IBaseStorage<Question>
    {
        public readonly ApplicationContext _db;

        public QuestionStorage(ApplicationContext db)
        {
            _db = db;
        }

        public async void Add(Question item)
        {
            await _db.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async void Delete(Question item)
        {
            _db.Remove(item);
            await _db.SaveChangesAsync();
        }

        public async Task<Question> Get(Guid id)
        {
            return await _db.Questions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Question>> GetAll()
        {
            return await _db.Questions.ToListAsync();
        }
    }
}
