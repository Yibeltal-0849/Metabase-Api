


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemType.ItemTypeInsert.ItemTypeInsertCommand
{

    /// @author  Shimels Alem  ItemTypeInsert stored procedure.


    public class ItemTypeInsertCommand : IRequest<IList<ItemType_Name>>
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public string Numbering_ID { get; set; }
		public string Starting_No { get; set; }
		public string Ending_No { get; set; }
		public System.DateTime? Last_Date_Used { get; set; }
		public string Last_No_Used { get; set; }
		public string Default_Nos { get; set; }
		public string Manual_Nos { get; set; }
		public System.DateTime Date_Order { get; set; }
		public string Gen_Bus_Posting_Group { get; set; }
		public System.Guid Service_Code { get; set; }
	}
		
		
		 
	}
 
 