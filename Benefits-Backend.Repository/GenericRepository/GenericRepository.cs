using Benefits_Backend.Repository.UnitOFWork;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.GenericRepository
{
    //public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    public GenericRepository(IUnitOfWork unitOfWork)
    //    {
    //        _unitOfWork = unitOfWork;
    //    }
    //    public async Task<TEntity> Add(TEntity entity)
    //    {
    //        await _unitOfWork.Context.Set<TEntity>().AddAsync(entity);
    //        return entity;
    //    }

    //    public void Delete(TEntity entity)
    //    {
    //        TEntity existing = _unitOfWork.Context.Set<TEntity>().Find(entity);
    //        if (existing != null) _unitOfWork.Context.Set<TEntity>().Remove(existing);
    //    }

    //    public TEntity Update(TEntity entity)
    //    {
    //        _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
    //        _unitOfWork.Context.Set<TEntity>().Attach(entity);
    //        return entity;
    //    }
    //}

}
