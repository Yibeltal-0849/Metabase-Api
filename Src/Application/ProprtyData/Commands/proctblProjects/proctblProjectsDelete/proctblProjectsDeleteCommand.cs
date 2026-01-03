 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblProjects.proctblProjectsDelete.proctblProjectsDeleteCommand
{

    // @author  Shimels Alem  proc_tblProjectsDelete stored procedure.


    public class proctblProjectsDeleteCommand : IRequest<IList<tblProjects_id>>
    {
       public long id { get; set; }
    }
		
     
		
		 
}
 
 