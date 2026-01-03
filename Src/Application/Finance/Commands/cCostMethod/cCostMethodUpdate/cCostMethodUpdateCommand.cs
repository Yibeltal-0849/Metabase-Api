using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cCostMethod.cCostMethodUpdate.cCostMethodUpdateCommand
{

	/// @author  Shimels Alem  c_Cost_MethodUpdate stored procedure.


	public class cCostMethodUpdateCommand : IRequest<IList<CCostMethod_ID>>
   {
		public string ID { get; set; }
		public string Name { get; set; }
	}
		
		
		 
	}

