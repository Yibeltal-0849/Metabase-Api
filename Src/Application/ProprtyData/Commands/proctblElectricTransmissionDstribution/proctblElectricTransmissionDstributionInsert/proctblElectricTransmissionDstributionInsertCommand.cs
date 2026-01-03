


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblElectricTransmissionDstribution.proctblElectricTransmissionDstributionInsert.proctblElectricTransmissionDstributionInsertCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Transmission_DstributionInsert stored procedure.


    public class proctblElectricTransmissionDstributionInsertCommand : IRequest<IList<tblElectricTransmissionDstribution_id>>
    {
        public long? id { get; set; }
        public long Region_id { get; set; }
        public System.DateTime Year { get; set; }
    }
		
		
		 
}
 
 