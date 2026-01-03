using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CTax.CTaxUpdate.CTaxUpdateCommand
{

	/// @author  Shimels Alem  C_TaxUpdate stored procedure.


	public class CTaxUpdateCommand : IRequest<IList<CTax_Code>>
   {
		public string Org_ID { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
}

