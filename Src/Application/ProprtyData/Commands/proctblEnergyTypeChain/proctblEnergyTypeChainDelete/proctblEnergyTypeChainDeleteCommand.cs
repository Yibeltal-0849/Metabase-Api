 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergyTypeChain.proctblEnergyTypeChainDelete.proctblEnergyTypeChainDeleteCommand
{

    // @author  Shimels Alem  proc_tblEnergy_Type_ChainDelete stored procedure.


    public class proctblEnergyTypeChainDeleteCommand : IRequest<IList<tblEnergyTypeChain_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 