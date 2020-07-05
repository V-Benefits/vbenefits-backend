using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using Benefits_Backend_Core.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.Services
{
    public class AppSettingService : IAppSettingService
    {
        private readonly IAppSettingRepository _appSettingRepository;
        public AppSettingService(IAppSettingRepository appSettingRepository)
        {
            _appSettingRepository = appSettingRepository;
        }

        public AppSetting GetAppSetting(string key)
        {
            throw new NotImplementedException();
        }

        public int GetPensionMaxPercent()
        {
            var maxValue = this._appSettingRepository.GetAppSetting("MaxPercentWithdrawal");
            return int.Parse(maxValue.Value); 
        }
    }
}
