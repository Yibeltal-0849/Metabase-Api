using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblVarableTables.proctblVarableTablesUpdate.proctblVarableTablesUpdateCommand
{

	/// @author  Shimels Alem  proc_tblVarable_TablesUpdate stored procedure.


	public class proctblVarableTablesUpdateCommand : IRequest<IList<tblVarableTables_id>>
   {
		public long id { get; set; }
		public long? Variable_id { get; set; }
		public long? VarB_Table_Detail_id { get; set; }
	}
		
		
		 
}

