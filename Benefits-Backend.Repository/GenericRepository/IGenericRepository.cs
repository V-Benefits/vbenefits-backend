using System.Threading.Tasks;

namespace Benefits_Backend.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //Task<TEntity> Add(TEntity entity);
        //void Delete(TEntity entity);
        //TEntity Update(TEntity entity);
    }
}
