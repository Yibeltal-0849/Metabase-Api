 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblSector.proctblSectorDelete.proctblSectorDeleteCommand
{

    // @author  Shimels Alem  proc_tblSectorDelete stored procedure.


    public class proctblSectorDeleteCommand : IRequest<IList<tblSector_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 