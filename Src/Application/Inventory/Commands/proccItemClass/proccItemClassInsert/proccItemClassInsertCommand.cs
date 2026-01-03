


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Inventory.Commands.proccItemClass.proccItemClassInsert.proccItemClassInsertCommand
{

    /// @author  Shimels Alem  proc_c_ItemClassInsert stored procedure.


    public class proccItemClassInsertCommand : IRequest<IList<CItemClass_Name>>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
    }
		
		
		 
}
 
 