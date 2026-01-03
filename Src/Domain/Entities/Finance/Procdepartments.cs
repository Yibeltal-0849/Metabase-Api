using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Finance
{
   public  class Proc_departments
    {
        public System.Guid department_Code { get; set; }
        public string department_Name { get; set; }
        public string Code { get; set; }
        public System.Guid departments_Department_Code { get; set; }
        public System.Guid organizations_Organization_Code { get; set; }
        public bool is_active { get; set; }


    }
}
