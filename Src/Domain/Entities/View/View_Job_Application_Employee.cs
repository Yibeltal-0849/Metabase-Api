using System;

namespace XOKA.Domain.Entities.view
{
    public  class View_Job_Application_Employee
    {
        public string FName { get; set; }     
        public string? LName { get; set; }
        public string? email { get; set; }
        public Guid Department_code { get; set; }
        public Guid? Structure_ID { get; set; }
        public string? department_name { get; set; }
        public string? Job_Title { get; set; }
        public bool? IS_Active { get; set; }
        public string? Address { get; set; }
        public string? Employee_Id { get; set; }
        public string? english_description { get; set; }
        public string? Cell_Phone_Number { get; set; }
        public Guid? lkdetail_code { get; set; }

    }
}
