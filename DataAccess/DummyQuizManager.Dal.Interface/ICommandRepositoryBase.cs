using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyQuizManager.Dal.Interface
{
    public interface ICommandRepositoryBase<T> where T:new()
    {
        Task<long> Create(T entity);
        Task<long> Delete(long id);
        Task<long> Update(T entity);
    }
}
