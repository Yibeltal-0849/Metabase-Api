using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStockBinDetailDelete.procStockBinDetailDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Stock_Bin_DetailDelete stored procedure.
	 
	#region proc_Stock_Bin_DetailDelete  
     
  /// proc_Stock_Bin_DetailDelete stored procedure.
     
        public class procStockBinDetailDeleteCommand : IRequest<IList<StockBinDetail_Store_ID>>
    {
        public DateTime date { get; set; }
        public string itemID { get; set; }
        public string store_ID { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
