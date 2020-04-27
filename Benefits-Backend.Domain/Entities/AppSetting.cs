using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class AppSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public ICollection<AppSeetingHistory> AppSeetingHistories { get; set; }

    }
}
