using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.Entities
{
   public class MedicalCardRequestForSpouse
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int RequestedById { get; set; }
        public Employee RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public bool isActive { get; set; } = false;
        //public bool isApproved { get; set; }
        public string SpouseName { get; set; }
        public string SpouseImage { get; set; }
        public string MarrigeCertificate { get; set; }

    }
}
