using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cUnit.cUnitUpdate.cUnitUpdateCommand
{

	/// @author  Shimels Alem  c_UnitUpdate stored procedure.


	public class cUnitUpdateCommand : IRequest<IList<CUnit_Unit>>
   {
		public string Unit { get; set; }
		public string Description { get; set; }
	}
		
		
		 
}

