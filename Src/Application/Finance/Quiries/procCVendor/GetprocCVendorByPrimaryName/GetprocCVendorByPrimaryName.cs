using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCVendor.GetprocCVendorLoadAll;

namespace Application.Finance.Quiries.procCVendor.GetprocCVendorByPrimaryName
{
    /// @author  Shimels Alem proc_C_VendorLoadByPrimaryKey stored procedure.

    public class GetprocCVendorByPrimaryName : IRequest<GetprocCVendorLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
