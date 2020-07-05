using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.Repositories
{
    public class MetlifeDataRepository : IMetlifeDataRepository
    {
        private readonly ApplicationContext context;
        public MetlifeDataRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public MetlifeData GetMetlifeDataForUser(int cert)
        {
            return context.metlifeData.FirstOrDefault(u => u.CERT == cert);
        }

        public bool Add(MetlifeData metlifeData)
        {
            try
            {
                 context.metlifeData.Add(metlifeData);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
