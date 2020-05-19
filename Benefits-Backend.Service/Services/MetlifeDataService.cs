using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
{
   public class MetlifeDataService : IMetlifeDataService
    {
        private readonly IMetlifeDataRepository metlifeDataRepository;

        public MetlifeDataService(IMetlifeDataRepository metlifeDataRepository)
        {
            this.metlifeDataRepository = metlifeDataRepository;
        }

      public bool AddMetlifeData(MetlifeData metlifeDataRecord)
        {
         
               if(! metlifeDataRepository.Add(metlifeDataRecord))
                {
                    return false;
                }
            else
            { 
                return true;
            }
        }
    }
}