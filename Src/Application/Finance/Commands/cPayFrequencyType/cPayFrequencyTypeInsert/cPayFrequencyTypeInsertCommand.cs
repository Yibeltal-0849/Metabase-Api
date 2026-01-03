


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayFrequencyType.cPayFrequencyTypeInsert.cPayFrequencyTypeInsertCommand
{

    /// @author  Shimels Alem  c_PayFrequencyTypeInsert stored procedure.


    public class cPayFrequencyTypeInsertCommand : IRequest<IList<CPayFrequencyType_Name>>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
    }
		
		
		 
}
 
 