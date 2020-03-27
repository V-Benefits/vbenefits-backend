using Benefits_Backend.Domain.Context;
using System;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.UnitOFWork
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationContext Context { get; }
        Task Commit();
    }
}
