using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPaymentMethod.cPaymentMethodUpdate.cPaymentMethodUpdateCommand
{

	/// @author  Shimels Alem  c_PaymentMethodUpdate stored procedure.


	public class cPaymentMethodUpdateCommand : IRequest<IList<CPaymentMethod_Id>>
   {
		public long Id { get; set; }
		public string Method { get; set; }
	}
		
		
		 
}

