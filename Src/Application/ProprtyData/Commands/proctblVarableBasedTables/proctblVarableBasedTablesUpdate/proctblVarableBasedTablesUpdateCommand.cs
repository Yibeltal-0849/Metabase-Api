using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblVarableBasedTables.proctblVarableBasedTablesUpdate.proctblVarableBasedTablesUpdateCommand
{

	/// @author  Shimels Alem  proc_tblVarableBasedTablesUpdate stored procedure.


	public class proctblVarableBasedTablesUpdateCommand : IRequest<IList<tblVarableBasedTables_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Type_Table_Name { get; set; }
	}
		
		
		 
}

