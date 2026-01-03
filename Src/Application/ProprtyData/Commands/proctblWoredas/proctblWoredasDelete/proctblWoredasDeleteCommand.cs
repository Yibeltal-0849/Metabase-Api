 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblWoredas.proctblWoredasDelete.proctblWoredasDeleteCommand
{

    // @author  Shimels Alem  proc_tblWoredasDelete stored procedure.


    public class proctblWoredasDeleteCommand : IRequest<IList<tblWoredas_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 