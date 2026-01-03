


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblWoredas.proctblWoredasInsert.proctblWoredasInsertCommand
{

	/// @author  Shimels Alem  proc_tblWoredasInsert stored procedure.


	public class proctblWoredasInsertCommand : IRequest<IList<tblWoredas_id>>
	{
		public long? id { get; set; }
		public string description { get; set; }
		public int? zones_id { get; set; }
	}
		
		
		 
}
 
 