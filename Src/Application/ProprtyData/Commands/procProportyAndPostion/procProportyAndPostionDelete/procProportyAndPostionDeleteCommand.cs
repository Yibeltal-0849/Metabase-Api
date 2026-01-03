 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyAndPostion.procProportyAndPostionDelete.procProportyAndPostionDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyAndPostionDeleteCommand : IRequest<IList<Proporty_And_PostionID>>
    {
        public System.Guid Id { get; set; }

    }
		
     
		
		 
}
 
 