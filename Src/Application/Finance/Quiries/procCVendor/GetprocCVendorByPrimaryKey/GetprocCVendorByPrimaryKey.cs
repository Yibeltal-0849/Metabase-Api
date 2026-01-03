using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCVendor.GetprocCVendorLoadAll;

namespace Application.Finance.Quiries.procCVendor.GetprocCVendorByPrimaryKey
{
    /// @author  Shimels Alem proc_C_VendorLoadByPrimaryKey stored procedure.

    public class GetprocCVendorByPrimaryKey : IRequest<GetprocCVendorLoadAllListVm>
    {
        public string Vendor_ID { get; set; }
    }
}
