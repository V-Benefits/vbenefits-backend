using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.IServices
{
    public interface IAppSettingService
    {
        AppSetting GetAppSetting(string key);
        int GetPensionMaxPercent();
    }
}
