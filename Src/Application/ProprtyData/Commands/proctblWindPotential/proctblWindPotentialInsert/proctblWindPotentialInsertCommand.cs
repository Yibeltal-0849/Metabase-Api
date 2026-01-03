


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblWindPotential.proctblWindPotentialInsert.proctblWindPotentialInsertCommand
{

    /// @author  Shimels Alem  proc_tblWindPotentialInsert stored procedure.


    public class proctblWindPotentialInsertCommand : IRequest<IList<tblWindPotential_id>>
    {
		public long? id { get; set; }
		public long? Resource_Id { get; set; }
		public long? Unit { get; set; }
		public string AAWS { get; set; }
		public string AAWD { get; set; }
		public string Measurement_Height { get; set; }
	}
		
		
		 
}
 
 