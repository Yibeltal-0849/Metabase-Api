using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cInventoryBeginingBalances.cInventoryBeginingBalancesUpdate.cInventoryBeginingBalancesUpdateCommand
{

	/// @author  Shimels Alem  c_Inventory_Begining_BalancesUpdate stored procedure.


	public class cInventoryBeginingBalancesUpdateCommand : IRequest<IList<CInventoryBeginingBalances_Id>>
   {
        public long Id { get; set; }
        public System.DateTime? Period { get; set; }
        public string OrgId { get; set; }
        public string Item_ID { get; set; }
        public string Description { get; set; }
        public decimal? Quantitiy { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
    }
		
		
		 
	}

