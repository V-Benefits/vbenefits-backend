using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Benefits_Backend_Core.Repository.Repositories
{
    public class AppSettingRepository : IAppSettingRepository
    {
        private readonly ApplicationContext context;

        public AppSettingRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public AppSetting GetAppSetting(string _key)
        {
            if (_key != null)
            {
                return context.AppSettings.FirstOrDefault(u => u.Key == _key);
            }
            return null;
        }
    }
}
