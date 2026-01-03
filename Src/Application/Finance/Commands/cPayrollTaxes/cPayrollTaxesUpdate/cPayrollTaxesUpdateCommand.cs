using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPayrollTaxes.cPayrollTaxesUpdate.cPayrollTaxesUpdateCommand
{

	/// @author  Shimels Alem  c_PayrollTaxesUpdate stored procedure.


	public class cPayrollTaxesUpdateCommand : IRequest<IList<CPayrollTaxes_Id>>
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

