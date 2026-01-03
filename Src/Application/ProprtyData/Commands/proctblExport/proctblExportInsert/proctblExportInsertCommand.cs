


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblExport.proctblExportInsert.proctblExportInsertCommand
{

    /// @author  Shimels Alem  proc_tblExportInsert stored procedure.


    public class proctblExportInsertCommand : IRequest<IList<tblExport_id>>
    {
		public long? id { get; set; }
		public long Company_id { get; set; }
		public long? Energy_Chain_id { get; set; }
		public long? Energy_id { get; set; }
		public long Buyer_id { get; set; }
		public System.DateTime Export_Period { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }
	}
		
		
		 
}
 
 