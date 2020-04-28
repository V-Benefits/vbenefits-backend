using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Benefits_Backend.Repository.Repositories
{
    public class AppSettingRepository : IAppSettingRepository
    {
        private readonly ApplicationContext context;

        public AppSettingRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public AppSetting GetAppSetting(string key)
        {
            return context.AppSettings.FirstOrDefault(u => u.Key == "MaxPercentWithdrawal");
        }
    }
}
