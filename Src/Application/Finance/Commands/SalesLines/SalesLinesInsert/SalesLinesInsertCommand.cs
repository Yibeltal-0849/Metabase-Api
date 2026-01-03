


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SalesLines.SalesLinesInsert.SalesLinesInsertCommand
{

    /// @author  Shimels Alem  Sales_LinesInsert stored procedure.


    public class SalesLinesInsertCommand : IRequest<IList<Sales_Lines_Sales_Line_ID>>
    {
		public string Sales_Line_ID { get; set; }
		public string Trans_No { get; set; }
		public string Type { get; set; }
		public string Contract_No { get; set; }
		public string No { get; set; }
		public string Description { get; set; }
		public string Location_Code { get; set; }
		public System.Int64? Quantity { get; set; }
		public string Unit { get; set; }
		public double? Unit_Price_Excl_VAT { get; set; }
		public double? Line_Amount_Excl_VAT { get; set; }
		public double? Line_Discount_Per { get; set; }
	}
		
		
		 
}
 
 