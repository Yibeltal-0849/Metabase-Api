using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeLoadAll;

namespace Application.FixedAsset.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeByPrimaryKey
{
    /// @author  Shimels Alem proc_Maintainance_PartsChangeLoadByPrimaryKey stored procedure.

    public class GetprocMaintainancePartsChangeByPrimaryKey : IRequest<GetprocMaintainancePartsChangeLoadAllListVm>
    {
        public System.Int64 PartsCange_ID { get; set; }
    }
}
