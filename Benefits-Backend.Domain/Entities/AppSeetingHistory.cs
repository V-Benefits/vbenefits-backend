using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class AppSeetingHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int ChangedById { get; set; }
        public Employee ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int AppSettingId { get; set; }
        public AppSetting AppSetting { get; set; }
    }
}
