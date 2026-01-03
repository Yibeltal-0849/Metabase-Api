using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStockBinDetailUpdate.procStockBinDetailUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Stock_Bin_DetailUpdate stored procedure.
	 
	#region proc_Stock_Bin_DetailUpdate  
     
  /// proc_Stock_Bin_DetailUpdate stored procedure.
     
        public class procStockBinDetailUpdateCommand : IRequest<IList<StockBinDetail_Store_ID>>
    {
		public string store_ID { get; set; }
		public string itemID { get; set; }
		public DateTime date { get; set; }
		public string vocher_No { get; set; }
		public double? in_QTY { get; set; }
		public double? iN_Unit_Price { get; set; }
		public double? iN_Total_Price { get; set; }
		public double? bal_QTY { get; set; }
		public double? bal_Unit_Price { get; set; }
		public double? bal_Total_Price { get; set; }
		public double? adjustment { get; set; }
		public bool? pOST_To_Account { get; set; }
		public double? remark { get; set; }
		public string log { get; set; }
	} 
		
        #endregion
		
		 
	}
 
 
