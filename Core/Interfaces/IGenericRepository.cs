using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
   public abstract class IGenericRepository<T> where T : BaseEntity
   {
      public abstract Task<T> GetByIdAsync(int id);

      public abstract Task<IReadOnlyList<T>> ListAllAsync();
   }
}