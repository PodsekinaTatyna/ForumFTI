using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumFTI.DAL.Interfaces
{
    public interface IBaseInteface<T>
    {

        void Add(T item);

        void Delete(T item);

        Task<T> Get(Guid id);

        Task<List<T>> GetAll();
        //bool Update(T item);
    }
}
