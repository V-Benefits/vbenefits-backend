using Benefits_Backend_Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Service.IServices
{
    public interface IAppSettingService
    {
        AppSetting GetAppSetting(string key);
        int GetPensionMaxPercent();
    }
}
