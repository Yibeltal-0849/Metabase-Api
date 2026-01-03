


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceDescriptions.proctblResourceDescriptionsInsert.proctblResourceDescriptionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceDescriptionsInsert stored procedure.


    public class proctblResourceDescriptionsInsertCommand : IRequest<IList<tblResourceDescriptions_id>>
    {
        public long? id { get; set; }
        public long? Resource_id { get; set; }
        public long? ResourceVariable_id { get; set; }
        public string Value { get; set; }
    }
		
		
		 
}
 
 