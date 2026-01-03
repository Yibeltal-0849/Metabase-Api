using System;

namespace XOKA.Domain.Entities.view
{
    public class ViewAspNetUsersWorkInfoDetail
    {
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; } 
        public string FirstName_en { get; set; }
        public string LastName_en { get; set; } 
        public string FirstName_Local { get; set; }
        public string LastName_Local { get; set; }
        public string MiddleName_en { get; set; } 
        public string MiddleName_Local { get; set; } 
        public string phone { get; set; } 
        public bool? Is_Employee { get; set; } 
        //public string Employee_Id { get; set; } 
        public System.Guid department_code { get; set; } 
        public string Code { get; set; }
        public string department_name { get; set; } 
        public System.Guid organization_code { get; set; }
        public string Registration_code { get; set; } 
        public string name_en { get; set; }
        public string name_local { get; set; } 
        public bool? IS_Active { get; set; }
        public bool? Active { get; set; }
        //public System.Guid? Structure_ID { get; set; }
    }
}
