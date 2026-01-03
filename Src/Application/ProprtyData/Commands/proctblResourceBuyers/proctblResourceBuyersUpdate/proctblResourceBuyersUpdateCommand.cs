using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceBuyers.proctblResourceBuyersUpdate.proctblResourceBuyersUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResourceBuyersUpdate stored procedure.


	public class proctblResourceBuyersUpdateCommand : IRequest<IList<tblResourceBuyers_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string FRB_Ownership { get; set; }
	}
		
		
		 
}

