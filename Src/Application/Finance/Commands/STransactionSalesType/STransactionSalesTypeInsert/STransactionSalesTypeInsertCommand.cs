


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.STransactionSalesType.STransactionSalesTypeInsert.STransactionSalesTypeInsertCommand
{

    /// @author  Shimels Alem  [S_Transaction Sales_TypeInsert] stored procedure.


    public class STransactionSalesTypeInsertCommand : IRequest<IList<STransactionSalesType_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Starting_No { get; set; }
        public string Ending_No { get; set; }
        public System.DateTime? Last_Date_Used { get; set; }
        public string Last_No_Used { get; set; }
        public string Default_Nos { get; set; }
        public string Manual_Nos { get; set; }
        public System.DateTime? Date_Order { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public System.Guid? Service_Code { get; set; }
    }
		
		
		 
}
 
 