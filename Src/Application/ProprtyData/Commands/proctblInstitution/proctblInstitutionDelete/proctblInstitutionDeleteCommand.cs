 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblInstitution.proctblInstitutionDelete.proctblInstitutionDeleteCommand
{

    // @author  Shimels Alem  proc_tblInstitutionDelete stored procedure.


    public class proctblInstitutionDeleteCommand : IRequest<IList<tblInstitution_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 