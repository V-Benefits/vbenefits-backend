using System;

namespace Benefits_Backend.Domain.Entities
{
   public class MedicalCardRequest
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int RequestedById { get; set; }
        public Employee RequestedBy { get; set; }
        public DateTime RequestedOn { get; set; }
        public bool isActive { get; set; } = false;
        public string PersonalImage { get; set; }
        public string SpouseName { get; set; }
        public string SpouseImage { get; set; }
        public string MarrigeCertificate { get; set; }
        public string ChildName { get; set; }
        public string ChildImage { get; set; }
        public string BirthCertificate { get; set; }
        public string RequestType { get; set; }
    }
}
