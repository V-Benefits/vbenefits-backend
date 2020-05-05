using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend.Repository.Repositories
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
    }
}
