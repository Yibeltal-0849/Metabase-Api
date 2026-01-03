 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblOrganizationType.proctblOrganizationTypeDelete.proctblOrganizationTypeDeleteCommand
{

    // @author  Shimels Alem  proc_tblOrganization_TypeDelete stored procedure.


    public class proctblOrganizationTypeDeleteCommand : IRequest<IList<tblOrganizationType_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 