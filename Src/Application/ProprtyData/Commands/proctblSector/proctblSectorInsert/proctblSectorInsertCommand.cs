


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblSector.proctblSectorInsert.proctblSectorInsertCommand
{

    /// @author  Shimels Alem  proc_tblSectorInsert stored procedure.


    public class proctblSectorInsertCommand : IRequest<IList<tblSector_id>>
    {
		public long? id { get; set; }
		public string Name { get; set; }
		public bool? Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Modified { get; set; }
	}
		
		
		 
}
 
 