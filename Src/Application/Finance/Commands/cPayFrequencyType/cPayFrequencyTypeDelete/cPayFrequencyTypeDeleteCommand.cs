 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayFrequencyType.cPayFrequencyTypeDelete.cPayFrequencyTypeDeleteCommand
{

    // @author  Shimels Alem  c_PayFrequencyTypeDelete stored procedure.


    public class cPayFrequencyTypeDeleteCommand : IRequest<IList<CPayFrequencyType_Name>>
    {
        public string Name { get; set; }
    }
		
     
		
		 
}
 
 