using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Pay_Slip.CreatePay_Slip
{
    /// @author  Shimels Alem  CreateCPay_Slip stored procedure.
    
    public class CreatePay_SlipCommand : IRequest<IList<PaySlip_Pay_Slip_ID>>
    {

			public System.Guid Pay_Slip_ID { get; set; }
			public System.Guid? Payrole_Trans_Id { get; set; }
			public System.Guid? Work_Info { get; set; }
			public string Employee_ID { get; set; }
			public string Payroll_NO { get; set; }
			public string Full_Name { get; set; }
			public string Job_Title { get; set; }
			public System.Double? Basic_Salary { get; set; }
			public System.Double? Total_Working_Days { get; set; }
			public System.Double? Absent_Yearly_Leave_With_Pay { get; set; }
			public System.Double? Absent_Yearly_Leave_Without_Pay { get; set; }
			public System.Double? Absent_Sick_Leave { get; set; }
			public System.Double? Absent_in_other_Typeof_Leave { get; set; }
			public System.Double? Absent_Weekend_And_Holiday { get; set; }
			public System.Double? Absent_With_Out_Approval { get; set; }
			public System.Double? Net_Working_Days { get; set; }
			public System.Double? OT_Price { get; set; }
			public System.Double? Addistion_Before_Tax { get; set; }
			public System.Double? Deduction_Before_Tax { get; set; }
			public string Addistion_After_tax { get; set; }
			public string Deduction_After_Tax { get; set; }
			public System.Double? Inc_Tax { get; set; }
			public System.Double? Pen_Tax { get; set; }
			public System.Double? Pen_From_Company { get; set; }
			public System.Double? Other_Didaction { get; set; }
			public string Bank_Account_No { get; set; }
			public System.Double? Net_Salary { get; set; }
			public bool? IS_Payed { get; set; }

		}
	}


