


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.J_Payroll_Journal.J_Payroll_JournalInsert.J_Payroll_JournalInsertCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceInsert stored procedure.


    public class J_Payroll_JournalInsertCommand : IRequest<IList<J_Payroll_Journal_Trans_ID>>
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
 
 