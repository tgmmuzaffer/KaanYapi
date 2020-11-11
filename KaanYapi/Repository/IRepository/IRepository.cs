using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Repository
{
   public interface IRepository<T> where T: class
    {
        T GetAsync(int Id);
        IEnumerable<T> GetAllAsync();
        bool CreateAsync(T objtoCreate);
        bool UpdateAsync(T objtoCreate);
        bool DeleteAsync(T objtoCreate);
        
    }
}
