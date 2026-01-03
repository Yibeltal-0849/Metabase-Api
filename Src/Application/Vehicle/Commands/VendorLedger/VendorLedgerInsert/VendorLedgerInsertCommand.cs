using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VendorLedger.VendorLedgerInsert.VendorLedgerInsertCommand
{

    ///  @author  Shimels Alem Vendor_LedgerInsert stored procedure.

    public class VendorLedgerInsertCommand : IRequest<IList<VendorLedger_Entry_No>>
    {
        public Int64? Entry_No { get; set; }
        public Int64? Posting_Date { get; set; }
        public Int64? Document_Type { get; set; }
        public Int64? Document_No { get; set; }
        public Int64? External_Document_No { get; set; }
        public Int64? Vendor_No { get; set; }
        public Int64? Description { get; set; }
        public Int64? Currency { get; set; }
        public Int64? Original_Amount { get; set; }
        public Int64? Amount { get; set; }
        public Int64? Remaining_Amount { get; set; }
        public Int64? Due_Date { get; set; }
        public Int64? Payment_Discount_Date { get; set; }
        public Int64? Payment_Discount_Tolernace_Date { get; set; }
        public Int64? Original_Payment_Discount_Possible { get; set; }
        public Int64? Remianing_Payment_Discount_Possible { get; set; }
        public Int64? Maximum_Payment_Tolerance { get; set; }
        public Int64? Opens { get; set; }
    }
		
		 
	}
 
 
