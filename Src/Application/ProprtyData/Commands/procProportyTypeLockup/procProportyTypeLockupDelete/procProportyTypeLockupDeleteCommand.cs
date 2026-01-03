 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyTypeLockup.procProportyTypeLockupDelete.procProportyTypeLockupDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyTypeLockupDeleteCommand : IRequest<IList<Proporty_Type_LookUpID>>
    {
        public int Property_Type_ID { get; set; }
    }
		
     
		
		 
}
 
 