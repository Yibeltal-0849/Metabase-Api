using System;

namespace XOKA.Domain.Entities.HRA
{
    public class House_Rent_Application
    {
        public System.Guid Rent_App_ID { get; set; }
        public System.Guid? Customer_Code { get; set; }
        public System.Guid Postion { get; set; }
        public System.Guid? Application_Date { get; set; }
        public bool? Is_Approved { get; set; }
        public Int64 Queue_number { get; set; }
        public string Orgnization_Name_Eng { get; set; }
        public string Orgnization_Name_Am { get; set; }

       
    }
}
