using System;

namespace XOKA.Domain.Entities.HRA
{
    public class EmployeeDoucment
    {
      
        public System.Guid ID { get; set; }
        public Guid Employee_Id { get; set; }
        public string Document_Name { get; set; }
 
        public byte[] Document_upload { get; set; }
        public string DocType { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Penshion { get; set; }
        public System.DateTime? Uploaded_Date { get; set; }


    }
}
