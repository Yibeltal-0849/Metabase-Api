using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.J_Payroll_Journal.J_Payroll_JournalUpdate.J_Payroll_JournalUpdateCommand
{

	/// @author  Shimels Alem  c_CA_Beginning_BalanceUpdate stored procedure.


	public class J_Payroll_JournalUpdateCommand : IRequest<IList<J_Payroll_Journal_Trans_ID>>
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
    }
		
		
		 
	}

