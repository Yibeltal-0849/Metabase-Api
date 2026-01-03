 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Inventory.Commands.proccItemClass.proccItemClassDelete.proccItemClassDeleteCommand
{

    // @author  Shimels Alem  proc_c_ItemClassDelete stored procedure.


    public class proccItemClassDeleteCommand : IRequest<IList<CItemClass_Name>>
    {
        public string Name { get; set; }
    }
		
     
		
		 
}
 
 