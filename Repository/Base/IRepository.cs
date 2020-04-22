using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Base
{
    public interface IRepository<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAll();
        Task<TModel> Get(int? id);
        Task<TModel> Add(TModel entity);
        Task<TModel> Update(TModel entity);
        Task<TModel> Delete(int? id);
    }
}
