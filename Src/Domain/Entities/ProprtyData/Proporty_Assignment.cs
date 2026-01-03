
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public  class Proporty_Assignment
    {
        public System.Guid Assig_Id { get; set; }
        public Nullable<System.Guid> Trans_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Proporty_ID { get; set; }
        public Nullable<System.Guid> Rent_App_ID { get; set; }
        public Nullable<System.Guid> Manual_Rent_App_ID { get; set; }
        public string Remark_for_Manual_Assigment { get; set; }
        public Nullable<bool> Approved { get; set; }
        public System.Guid UserID { get; set; }
    }
}
