


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblRegions.proctblRegionsInsert.proctblRegionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblRegionsInsert stored procedure.


    public class proctblRegionsInsertCommand : IRequest<IList<tblRegions_id>>
    {
        public long? id { get; set; }
        public string description { get; set; }
    }
		
		
		 
}
 
 