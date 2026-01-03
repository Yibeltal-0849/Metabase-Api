using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.StockBinDetail.StockBinDetailUpdate.StockBinDetailUpdateCommand
{

	/// @author  Shimels Alem  Stock_Bin_DetailUpdate stored procedure.


	public class StockBinDetailUpdateCommand : IRequest<IList<StockBinDetail_Store_ID>>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
        public System.DateTime Date { get; set; }
        public string Vocher_No { get; set; }
        public double? In_QTY { get; set; }
        public double? IN_Unit_Price { get; set; }
        public double? IN_Total_Price { get; set; }
        public double? Bal_QTY { get; set; }
        public double? Bal_Unit_Price { get; set; }
        public double? Bal_Total_Price { get; set; }
        public double? Adjustment { get; set; }
        public bool? POST_To_Account { get; set; }
        public string Remark { get; set; }
        public string Log { get; set; }
    }
		
		
		 
	}

