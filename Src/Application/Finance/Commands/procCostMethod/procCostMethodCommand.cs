using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCostMethod.procCostMethodCommand
{ 
	 
	/// @author  Henok Solomon  proc_CostMethod stored procedure.
	 
	#region proc_CostMethod  
     
  /// proc_CostMethod stored procedure.
     
        public class procCostMethodCommand : IRequest<IList<procCostMethod_store_Code>>
    {
    
		public string store_Code { get; set; }
		public string itemID { get; set; }
		public double unit_Price { get; set; }
		public int bal_QTY { get; set; }
		public string costMethod { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
