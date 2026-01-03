 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblElectricTransmissionDstribution.proctblElectricTransmissionDstributionDelete.proctblElectricTransmissionDstributionDeleteCommand
{

    // @author  Shimels Alem  proc_tblElectric_Transmission_DstributionDelete stored procedure.


    public class proctblElectricTransmissionDstributionDeleteCommand : IRequest<IList<tblElectricTransmissionDstribution_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 