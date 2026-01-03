 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergyChain.proctblEnergyChainDelete.proctblEnergyChainDeleteCommand
{

    // @author  Shimels Alem  proc_tblEnergyChainDelete stored procedure.


    public class proctblEnergyChainDeleteCommand : IRequest<IList<tblEnergyChain_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 