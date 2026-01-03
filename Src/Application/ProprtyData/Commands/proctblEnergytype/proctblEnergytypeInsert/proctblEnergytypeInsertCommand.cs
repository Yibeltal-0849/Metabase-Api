


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergytype.proctblEnergytypeInsert.proctblEnergytypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergy_typeInsert stored procedure.


    public class proctblEnergytypeInsertCommand : IRequest<IList<tblEnergytype_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
    }
		
		
		 
}
 
 