using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        // T - Category
        IEnumerable<T> GetAll();
        /// <summary>
        /// 單一搜尋，Expression為表達式，Func<T,bool>為委託 用來過濾條件
        /// </summary>
        /// <param name="fillter"></param>
        /// <returns></returns>
        T Get(Expression<Func<T,bool>> fillter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
