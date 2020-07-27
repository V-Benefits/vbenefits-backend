using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class RatePlanTypeLookup
    {
        public int Id { set; get; }
        public string Key { set; get; }
        public string Value { set; get; }
        public int RequestTypeId { set; get; }
        public RequestTypeLookup RequestType { set; get; }
    }
}
