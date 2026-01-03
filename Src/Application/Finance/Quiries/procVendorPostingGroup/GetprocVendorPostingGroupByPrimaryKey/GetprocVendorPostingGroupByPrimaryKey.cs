using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procVendorPostingGroup.GetprocVendorPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVendorPostingGroup.GetprocVendorPostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_Vendor_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetprocVendorPostingGroupByPrimaryKey : IRequest<GetprocVendorPostingGroupLoadAllListVm>
    {
        public string Code { get; set; }
        public string Payables_Account { get; set; }
        public string Service_Charge_Account { get; set; }
        public string Payment_Disc_Debit_Account { get; set; }
        public string Payment_Disc_Credit_Account { get; set; }
        public string Interest_Account { get; set; }
        public int? Payment_tolerances_InDay { get; set; }
    }
}
