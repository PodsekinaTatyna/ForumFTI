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
    public class CommentStorage : IBaseStorage<Comment>
    {
        public readonly ApplicationContext _db;

        public CommentStorage(ApplicationContext db)
        {
            _db = db;
        }

        public async void Add(Comment item)
        {
            await _db.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public void Delete(Comment item)
        {
            throw new NotImplementedException();
        }

        public async Task<Comment> Get(Guid id)
        {
            return await _db.Comments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Comment>> GetAll()
        {
            return await _db.Comments.ToListAsync();
        }
    }
}
