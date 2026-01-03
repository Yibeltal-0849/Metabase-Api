 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergy.proctblEnergyDelete.proctblEnergyDeleteCommand
{

    // @author  Shimels Alem  proc_tblEnergyDelete stored procedure.


    public class proctblEnergyDeleteCommand : IRequest<IList<tblEnergy_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 