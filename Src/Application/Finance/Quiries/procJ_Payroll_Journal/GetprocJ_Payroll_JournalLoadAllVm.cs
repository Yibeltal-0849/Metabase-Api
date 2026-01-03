using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJ_Payroll_Journal
{
    public class GetprocJ_Payroll_JournalLoadAllVm : IMapFrom<J_Payroll_Journal>
    {
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Emplyee_ID { get; set; }
        public string Payroll_No { get; set; }
        public Nullable<double> Total_Gross_Salary { get; set; }
        public Nullable<double> Gross_Salary { get; set; }
        public Nullable<double> Net_Salary { get; set; }
        public Nullable<double> Inc_Tax_Amount { get; set; }
        public Nullable<double> Pen_Tax_Amount { get; set; }
        public Nullable<double> Com_Pen_Amount { get; set; }
        public Nullable<double> Over_Time_Amount { get; set; }
        public Nullable<double> Allwance_Amount { get; set; }
        public Nullable<double> Other_Amount { get; set; }
        public Nullable<bool> Applies_to_Entry { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<J_Payroll_Journal, GetprocJ_Payroll_JournalLoadAllVm>();
        }
    }
}
