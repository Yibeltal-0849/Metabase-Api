using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procVendorLedger.GetprocVendorLedgerLoadAll;

namespace Application.Finance.Quiries.procVendorLedger.GetprocVendorLedgerByPrimaryKey
{
    /// @author  Shimels Alem proc_Vendor_LedgerLoadByPrimaryKey stored procedure.

    public class GetprocVendorLedgerByPrimaryKey : IRequest<GetprocVendorLedgerLoadAllListVm>
    {
        public System.Int64 Entry_No { get; set; }
    }
}
