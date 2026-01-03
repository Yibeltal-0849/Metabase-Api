


using MediatR;
using System;
using XOKA.Domain.Entities.HRA;
using System.Collections.Generic;

namespace Application.HRA.Commands.procCourtOrderDeduction.procCourtOrderDeductionInsert.procCourtOrderDeductionInsertCommand
{

	/// @author  Shimels Alem  proc_Court_Order_DeductionInsert stored procedure.


	public class procCourtOrderDeductionInsertCommand : IRequest<IList<CourtOrderDeduction_CourtOrderID>>
    {
		public System.Guid Court_Order_ID { get; set; }
		public string Employee_ID { get; set; }
		public string Sub_Account_No { get; set; }
		public string Payee_Name { get; set; }
		public double? Amount { get; set; }
		public byte[] Court_Letter { get; set; }
	}
		
		
		 
}
 
 