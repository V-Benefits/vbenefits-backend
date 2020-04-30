using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benefits_Backend.Repository.Repositories
{
    public class MetlifeDataRepositor : IMetlifeDataRepository
    {
        private readonly ApplicationContext context;
        public MetlifeDataRepositor(ApplicationContext context)
        {
            this.context = context;
        }
        public MetlifeData GetMetlifeDataForUser(string name)
        {
            return context.metlifeData.FirstOrDefault(u => u.Name == name);
        }
    }
}
