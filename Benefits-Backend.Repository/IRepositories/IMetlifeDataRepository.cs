using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.IRepositories
{
    public interface IMetlifeDataRepository
    {
        //TO BE CHANGED TO int ID 
        MetlifeData GetMetlifeDataForUser(int cert);
        bool Add(MetlifeData metlifeData);
    }
}
