using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using Benefits_Backend_Core.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.Services
{
   public class MetlifeDataService : IMetlifeDataService
    {
        private readonly IMetlifeDataRepository metlifeDataRepository;

        public MetlifeDataService(IMetlifeDataRepository metlifeDataRepository)
        {
            this.metlifeDataRepository = metlifeDataRepository;
        }

      public bool AddMetlifeDataRecord(MetlifeData metlifeDataRecord)
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