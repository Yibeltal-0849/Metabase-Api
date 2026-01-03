


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchasecreditmemo.PPurchasecreditmemoInsert.PPurchasecreditmemoInsertCommand
{

    /// @author  Shimels Alem  [P_Purchase credit memoInsert] stored procedure.


    public class PPurchasecreditmemoInsertCommand : IRequest<IList<PPurchaseCreditMemo_Purchase_Line>>
    {
        public System.Guid? Purchase_Line { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public string Job_Line_Type { get; set; }
        public string Job_Task_No { get; set; }
        public double? Job_Unit_Price { get; set; }
        public double? Job_Total_Price { get; set; }
        public double? Job_Line_Amount { get; set; }
        public double? Job_Line_Discount_Amount { get; set; }
        public double? Job_Line_Discount_Per { get; set; }
        public double? Job_Unit_Price_LCY { get; set; }
        public double? Job_Total_Price_LCY { get; set; }
        public double? Job_Line_Amount_LCY { get; set; }
        public double? Job_Line_Disc_Amount_LCY { get; set; }
    }
		
		
		 
}
 
 