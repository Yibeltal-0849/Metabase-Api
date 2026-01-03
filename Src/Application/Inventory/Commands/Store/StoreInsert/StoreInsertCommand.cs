


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.Store.StoreInsert.StoreInsertCommand
{

    /// @author  Shimels Alem  StoreInsert stored procedure.


    public class StoreInsertCommand : IRequest<IList<_Store_Store_code>>
    {
        public string Store_code { get; set; }
        public string Store_Name { get; set; }
        public System.Guid? Store_Type { get; set; }
        public System.Guid? Organization { get; set; }
        public System.Guid? DIV { get; set; }
        public string Location { get; set; }
        public string Log { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
	}
 
 