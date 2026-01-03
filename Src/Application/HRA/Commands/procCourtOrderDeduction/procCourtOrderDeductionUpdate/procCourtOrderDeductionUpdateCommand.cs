using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.HRA;
using System.Collections.Generic;

namespace Application.HRA.Commands.procCourtOrderDeduction.procCourtOrderDeductionUpdate.procCourtOrderDeductionUpdateCommand
{

	/// @author  Shimels Alem  proc_Court_Order_DeductionUpdate stored procedure.


	public class procCourtOrderDeductionUpdateCommand : IRequest<IList<CourtOrderDeduction_CourtOrderID>>
   {
		public System.Guid Court_Order_ID { get; set; }
		public string Employee_ID { get; set; }
		public string Sub_Account_No { get; set; }
		public string Payee_Name { get; set; }
		public double? Amount { get; set; }
		public byte[] Court_Letter { get; set; }
	}
		
		
		 
}

