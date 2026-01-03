


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblImportDescriptions.proctblImportDescriptionsInsert.proctblImportDescriptionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblImport_DescriptionsInsert stored procedure.


    public class proctblImportDescriptionsInsertCommand : IRequest<IList<tblImportDescriptions_id>>
    {
        public long? id { get; set; }
        public long? Import_Id { get; set; }
        public long? Variable_id { get; set; }
        public string Value { get; set; }
    }
		
		
		 
}
 
 