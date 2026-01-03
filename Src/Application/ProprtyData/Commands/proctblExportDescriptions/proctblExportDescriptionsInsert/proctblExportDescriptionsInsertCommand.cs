


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblExportDescriptions.proctblExportDescriptionsInsert.proctblExportDescriptionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblExport_DescriptionsInsert stored procedure.


    public class proctblExportDescriptionsInsertCommand : IRequest<IList<tblExportDescriptions_id>>
    {
        public long? id { get; set; }
        public long? Export_Id { get; set; }
        public long? Variable_id { get; set; }
        public string Value { get; set; }
    }
		
		
		 
}
 
 