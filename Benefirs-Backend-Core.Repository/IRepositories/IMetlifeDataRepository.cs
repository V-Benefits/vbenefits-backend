using Benefits_Backend_Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.IRepositories
{
    public interface IMetlifeDataRepository
    {
        //TO BE CHANGED TO int ID 
        MetlifeData GetMetlifeDataForUser(int cert);
        bool Add(MetlifeData metlifeData);
    }
}
