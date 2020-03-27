using Benefits_Backend.Domain.Context;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.UnitOFWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationContext Context { get; }

        public UnitOfWork(ApplicationContext context)
        {
            Context = context;
        }
        public async Task Commit()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
