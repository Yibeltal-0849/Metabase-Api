


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayrollTaxes.cPayrollTaxesInsert.cPayrollTaxesInsertCommand
{

    /// @author  Shimels Alem  c_PayrollTaxesInsert stored procedure.


    public class cPayrollTaxesInsertCommand : IRequest<IList<CPayrollTaxes_Id>>
    {
        public long Id { get; set; }
        public string Orgcode { get; set; }
        public string TaxAgencyCode { get; set; }
        public string Tax_Liability_Acc_No { get; set; }
        public string Tax_Expense_Axx_No { get; set; }
        public string Compnay_Contribution { get; set; }
        public string Employe_Contribution { get; set; }
        public string Pen_Company_GL { get; set; }
        public string Pen_Employe_GL { get; set; }
    }
		
		
		 
}
 
 