using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class RequestTypeLookup
    {
        public int Id { set; get; }
        public string Value { set; get; }
        public int RequestForId { set; get; }
        public RequestForLookup RequestFor { set; get; }
    }
}
