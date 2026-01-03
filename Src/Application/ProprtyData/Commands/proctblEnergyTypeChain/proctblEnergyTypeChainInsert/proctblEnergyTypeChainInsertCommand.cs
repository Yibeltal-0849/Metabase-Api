


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergyTypeChain.proctblEnergyTypeChainInsert.proctblEnergyTypeChainInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergy_Type_ChainInsert stored procedure.


    public class proctblEnergyTypeChainInsertCommand : IRequest<IList<tblEnergyTypeChain_id>>
    {
        public long? id { get; set; }
        public long? Energy_Type_id { get; set; }
        public long? Energy_Chain_id { get; set; }
    }
		
		
		 
}
 
 