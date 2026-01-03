


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFaclitiyDescription.proctblFaclitiyDescriptionInsert.proctblFaclitiyDescriptionInsertCommand
{

    /// @author  Shimels Alem  proc_tblFaclitiy_DescriptionInsert stored procedure.


    public class proctblFaclitiyDescriptionInsertCommand : IRequest<IList<tblFaclitiyDescription_id>>
    {
        public long? id { get; set; }
        public long? Facility_id { get; set; }
        public long? Variable_id { get; set; }
        public string Value { get; set; }
    }
		
		
		 
}
 
 