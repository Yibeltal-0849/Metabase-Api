 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergyProduc.proctblEnergyProducDelete.proctblEnergyProducDeleteCommand
{

    // @author  Shimels Alem  proc_tblEnergyProducDelete stored procedure.


    public class proctblEnergyProducDeleteCommand : IRequest<IList<tblEnergyProduc_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 