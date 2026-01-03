


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblImport.proctblImportInsert.proctblImportInsertCommand
{

    /// @author  Shimels Alem  proc_tblImportInsert stored procedure.


    public class proctblImportInsertCommand : IRequest<IList<tblImport_id>>
    {
		public long? id { get; set; }
		public long Company_id { get; set; }
		public long? Energy_Chain_id { get; set; }
		public long? Energy_id { get; set; }
		public long Supplier_id { get; set; }
		public System.DateTime Imported_Period { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }
	}
		
		
		 
}
 
 