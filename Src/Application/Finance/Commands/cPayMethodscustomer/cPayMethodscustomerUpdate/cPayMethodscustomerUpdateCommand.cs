using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPayMethodscustomer.cPayMethodscustomerUpdate.cPayMethodscustomerUpdateCommand
{

	/// @author  Shimels Alem  c_Pay_Methods_customerUpdate stored procedure.


	public class cPayMethodscustomerUpdateCommand : IRequest<IList<CPayMethodsCustomer_Id>>
   {
		public long Id { get; set; }
		public string Customer_ID { get; set; }
		public long? Type { get; set; }
	}
		
		
		 
}

