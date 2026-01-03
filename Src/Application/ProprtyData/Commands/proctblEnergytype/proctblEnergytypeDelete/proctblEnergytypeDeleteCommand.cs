 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergytype.proctblEnergytypeDelete.proctblEnergytypeDeleteCommand
{

    // @author  Shimels Alem  proc_tblEnergy_typeDelete stored procedure.


    public class proctblEnergytypeDeleteCommand : IRequest<IList<tblEnergytype_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 