using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procMaintainancePartsChange.procMaintainancePartsChangeUpdate.procMaintainancePartsChangeUpdateCommand
{

	/// @author  Shimels Alem  proc_Maintainance_PartsChangeUpdate stored procedure.


	public class procMaintainancePartsChangeUpdateCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
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

