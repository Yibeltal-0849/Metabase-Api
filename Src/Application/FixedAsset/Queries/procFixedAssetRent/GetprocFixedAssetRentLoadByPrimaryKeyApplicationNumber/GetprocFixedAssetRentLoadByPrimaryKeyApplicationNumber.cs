using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Fixed_Asset_RentLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocFixedAssetRentLoadByPrimaryKeyApplicationNumber : IRequest<GetprocFixedAssetRentLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
