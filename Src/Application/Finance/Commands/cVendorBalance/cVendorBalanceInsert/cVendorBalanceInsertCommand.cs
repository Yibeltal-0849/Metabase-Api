


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cVendorBalance.cVendorBalanceInsert.cVendorBalanceInsertCommand
{

    /// @author  Shimels Alem  c_Vendor_BalanceInsert stored procedure.


    public class cVendorBalanceInsertCommand : IRequest<IList<CVendor_Vendor_ID>>
    {
        public long? Id { get; set; }
        public string Org_id { get; set; }
        public string Vendor_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_or_R_Account { get; set; }
    }
		
		
		 
}
 
 