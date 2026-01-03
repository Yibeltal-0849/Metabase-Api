 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFaclitiyDescription.proctblFaclitiyDescriptionDelete.proctblFaclitiyDescriptionDeleteCommand
{

    // @author  Shimels Alem  proc_tblFaclitiy_DescriptionDelete stored procedure.


    public class proctblFaclitiyDescriptionDeleteCommand : IRequest<IList<tblFaclitiyDescription_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 