using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Finance
{

       public  class Emplyee_Type_Posting_Group
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Gross_Salary_Account { get; set; }
        public string Net_Salary_Account { get; set; }
        public string Inc_Tax_Account { get; set; }
        public string Pen_Tax_Account { get; set; }
        public string Com_Pen_Cont_Account { get; set; }
        public string Over_Time_Account { get; set; }
        public string Allwance_Account { get; set; }
        public string CostSharing { get; set; }
        public string Pen_Tax_Cost { get; set; }
        public string Other_Account { get; set; }
        public Nullable<System.Guid> Branch_ID { get; set; }
    }
}
