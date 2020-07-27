using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
    public class RequestForLookup
    {
        public int Id { set; get; }
        public string Value { set; get; }
        public List<RequestTypeLookup> RequestTypeLookups { get; set; }
    }
}
