


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procMaintainancePartsChange.procMaintainancePartsChangeInsert.procMaintainancePartsChangeInsertCommand
{

	/// @author  Shimels Alem  proc_Maintainance_PartsChangeInsert stored procedure.


	public class procMaintainancePartsChangeInsertCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
    {
		public long? PartsCange_ID { get; set; }
		public string Maintainance_ID { get; set; }
		public System.Double? Unit_Cost { get; set; }
		public System.Double? Quantity { get; set; }
		public System.Double? Total_Cost { get; set; }
		public string Transfer_Req_DetailID { get; set; }
		public string Item_ID { get; set; }
		public bool? IsChanged { get; set; }
	}
		
		
		 
}
 
 