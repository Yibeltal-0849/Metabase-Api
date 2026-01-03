using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblVarableBasedTableDetail.proctblVarableBasedTableDetailUpdate.proctblVarableBasedTableDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_tblVarableBasedTable_DetailUpdate stored procedure.


	public class proctblVarableBasedTableDetailUpdateCommand : IRequest<IList<tblVarableBasedTableDetail_id>>
   {
		public long id { get; set; }
		public long Table_id { get; set; }
		public long EnergyChain_id { get; set; }
		public long Type_id { get; set; }
	}
		
		
		 
}

