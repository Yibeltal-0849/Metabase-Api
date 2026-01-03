using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Asset_RentLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetRentByPrimaryKey : IRequest<GetprocFixedAssetRentLoadAllListVm>
    {
        public long Rent_ID { get; set; }
    }
}
