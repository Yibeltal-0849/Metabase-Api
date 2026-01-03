 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.ProcProportyStaticData.ProcProportyStaticDataDelete.ProcProportyStaticDataDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class ProcProportyStaticDataDeleteCommand : IRequest<IList<Proporty_Static_DataID>>
    {
  
            public System.Guid ID { get; set; }
         
    }
		
     
		
		 
}
 
 