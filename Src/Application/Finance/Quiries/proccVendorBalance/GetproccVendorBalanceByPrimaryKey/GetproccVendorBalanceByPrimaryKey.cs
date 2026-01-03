using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccVendorBalance.GetproccVendorBalanceLoadAll;

namespace Application.Finance.Quiries.proccVendorBalance.GetproccVendorBalanceByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Vendor_BalanceLoadByPrimaryKey stored procedure.

    public class GetproccVendorBalanceByPrimaryKey : IRequest<GetproccVendorBalanceLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
