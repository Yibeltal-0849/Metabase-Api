


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.VendorPostingGroup.VendorPostingGroupInsert.VendorPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Vendor_Posting_GroupInsert stored procedure.


    public class VendorPostingGroupInsertCommand : IRequest<IList<VendorPostingGroup_Code>>
    {
        public string Code { get; set; }
        public string Payables_Account { get; set; }
        public string Service_Charge_Account { get; set; }
        public string Payment_Disc_Debit_Account { get; set; }
        public string Payment_Disc_Credit_Account { get; set; }
        public string Interest_Account { get; set; }
        public int? Payment_tolerances_InDay { get; set; }
        public bool? IsActive { get; set; }
    }
		
		
		 
}
 
 