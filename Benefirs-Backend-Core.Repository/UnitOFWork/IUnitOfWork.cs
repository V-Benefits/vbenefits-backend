using Benefits_Backend_Core.Domain.Context;
using System;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.UnitOFWork
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationContext Context { get; }
        Task Commit();
    }
}
