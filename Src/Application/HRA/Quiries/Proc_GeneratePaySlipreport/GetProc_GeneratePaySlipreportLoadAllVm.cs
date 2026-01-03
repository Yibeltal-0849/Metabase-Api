using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.Proc_GeneratePaySlipreport
{
    public class GetProc_GeneratePaySlipreportLoadAllVm : IMapFrom<GeneratePaySlipreport>
    {

        public System.Guid? Pay_Slip_ID { get; set; }
        public System.Guid? Payrole_Trans_Id { get; set; }
        public System.Guid? Work_Info { get; set; }
        public string Employee_ID { get; set; }
        public string Payroll_NO { get; set; }
        public string Full_Name { get; set; }
        public string Job_Title { get; set; }
        public Double Basic_Salary { get; set; }
        public Double Total_Working_Days { get; set; }
        public Double Absent_Yearly_Leave_With_Pay { get; set; }
        public Double Absent_Yearly_Leave_Without_Pay { get; set; }
        public Double Absent_Sick_Leave { get; set; }
        public Double Absent_in_other_Typeof_Leave { get; set; }
        public Double Absent_Weekend_And_Holiday { get; set; }
        public Double Absent_With_Out_Approval { get; set; }
        public Double Net_Working_Days { get; set; }
        public Double OT_Price { get; set; }
        public Double Addistion_Before_Tax { get; set; }
        public Double Deduction_Before_Tax { get; set; }
        public string Addistion_After_tax { get; set; }
        public string Deduction_After_Tax { get; set; }
        public Double Inc_Tax { get; set; }
        public Double Pen_Tax { get; set; }
        public Double Other_Didaction { get; set; }
        public string Bank_Account_No { get; set; }
        public Double Net_Salary { get; set; }
        public bool IS_Payed { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GeneratePaySlipreport, GetProc_GeneratePaySlipreportLoadAllVm>();
        }
    }
}
