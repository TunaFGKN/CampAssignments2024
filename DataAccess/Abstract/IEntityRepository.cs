using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id); // Expression filter ile refactor edilecek.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
