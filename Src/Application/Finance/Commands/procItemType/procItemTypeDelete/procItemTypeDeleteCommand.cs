 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Commands.procItemType.procItemTypeDelete.procItemTypeDeleteCommand
{

    // @author  Shimels Alem  proc_ItemTypeDelete stored procedure.


    public class procItemTypeDeleteCommand : IRequest<IList<ItemType_Name>>
    {
        public string Name { get; set; }
    }
		
     
		
		 
}
 
 