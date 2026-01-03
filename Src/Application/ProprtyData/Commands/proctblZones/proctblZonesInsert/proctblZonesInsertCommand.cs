


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblZones.proctblZonesInsert.proctblZonesInsertCommand
{

    /// @author  Shimels Alem  proc_tblZonesInsert stored procedure.


    public class proctblZonesInsertCommand : IRequest<IList<tblZones_id>>
    {
        public int? id { get; set; }
        public string description { get; set; }
        public long? regions_id { get; set; }
    }
		
		
		 
}
 
 