


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cInventoryBeginingBalances.cInventoryBeginingBalancesInsert.cInventoryBeginingBalancesInsertCommand
{

	/// @author  Shimels Alem  c_Inventory_Begining_BalancesInsert stored procedure.


	public class cInventoryBeginingBalancesInsertCommand : IRequest<IList<CInventoryBeginingBalances_Id>>
    {
        public long? Id { get; set; }
        public System.DateTime? Period { get; set; }
        public string OrgId { get; set; }
        public string Item_ID { get; set; }
        public string Description { get; set; }
        public decimal? Quantitiy { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
    }
		
		
		 
	}
 
 