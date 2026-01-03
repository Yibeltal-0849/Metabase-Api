


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LCustomerLedgerEntries.LCustomerLedgerEntriesInsert.LCustomerLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_Customer_Ledger_EntriesInsert stored procedure.


    public class LCustomerLedgerEntriesInsertCommand : IRequest<IList<LCustomerLedgerEntries_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Customer_No { get; set; }
        public string Description { get; set; }
        public System.Guid? Currency_Code { get; set; }
        public double? Original_Amount { get; set; }
        public double? Amount { get; set; }
        public double? Remaining_Amount { get; set; }
        public System.DateTime? Due_Date { get; set; }
        public System.DateTime? Pmt_Discount_Date { get; set; }
        public System.DateTime? Pmt_Disc_Tolerance_Date { get; set; }
        public System.DateTime? Original_Pmt_Disc_Possible { get; set; }
        public double? Remaining_Pmt_Disc_Possible { get; set; }
        public double? Max_Payment_Tolerance { get; set; }
        public bool? Open { get; set; }
        public bool? On_Hold { get; set; }
        public long Entry_No { get; set; }
    }
		
		
		 
}
 
 