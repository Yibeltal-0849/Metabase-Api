 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFacilityType.proctblFacilityTypeDelete.proctblFacilityTypeDeleteCommand
{

    // @author  Shimels Alem  proc_tblFacility_TypeDelete stored procedure.


    public class proctblFacilityTypeDeleteCommand : IRequest<IList<tblFacility_Type_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 