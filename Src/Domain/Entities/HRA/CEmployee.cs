using System;

namespace XOKA.Domain.Entities.HRA
{
    public class CEmployee
    {
  
        public Guid User_ID { get; set; }
        public Guid? Type_Employement { get; set; }
        public string Payrole_No { get; set; }
        public string TIN { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string IDNumber { get; set; }
        public string Photo { get; set; }
  
        public DateTime? BirthDate { get; set; }
        public Guid Marrage_Status { get; set; }
        public Guid Gender { get; set; }
        public Guid Country { get; set; }
        public bool? Active { get; set; }
        public DateTime? Hired { get; set; }
        public DateTime? Terminated { get; set; }
        public DateTime? Rehired { get; set; }
        public string Log { get; set; }
        public string Leave { get; set; }
        public string Mather_FullNme { get; set; }
        public string Emplyee_Type_Posting_Group { get; set; }
        public string commitee_participation { get; set; }
    }
}
