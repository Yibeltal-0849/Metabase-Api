


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Finance.Commands.procVendorLedger.procVendorLedgerInsert.procVendorLedgerInsertCommand
{

    /// @author  Shimels Alem  proc_Vendor_LedgerInsert stored procedure.


    public class procVendorLedgerInsertCommand : IRequest<IList<VendorLedger_Entry_No>>
    {
        public System.Int64 Entry_No { get; set; }
        public System.Int64? Posting_Date { get; set; }
        public System.Int64? Document_Type { get; set; }
        public System.Int64? Document_No { get; set; }
        public System.Int64? External_Document_No { get; set; }
        public System.Int64? Vendor_No { get; set; }
        public System.Int64? Description { get; set; }
        public System.Int64? Currency { get; set; }
        public System.Int64? Original_Amount { get; set; }
        public System.Int64? Amount { get; set; }
        public System.Int64? Remaining_Amount { get; set; }
        public System.Int64? Due_Date { get; set; }
        public System.Int64? Payment_Discount_Date { get; set; }
        public System.Int64? Payment_Discount_Tolernace_Date { get; set; }
        public System.Int64? Original_Payment_Discount_Possible { get; set; }
        public System.Int64? Remianing_Payment_Discount_Possible { get; set; }
        public System.Int64? Maximum_Payment_Tolerance { get; set; }
        public System.Int64? Opens { get; set; }
    }



}
 
 