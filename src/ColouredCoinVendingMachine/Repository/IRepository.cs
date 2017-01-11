using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColouredCoinVendingMachine.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> All { get; }

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T FindById(String id);
    }
}
