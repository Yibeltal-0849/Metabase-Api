using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeLoadAll;

namespace Application.Finance.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeByPrimaryKey
{
    /// @author  Shimels Alem proc_Maintainance_PartsChangeLoadByPrimaryKey stored procedure.

    public class GetprocMaintainancePartsChangeByPrimaryKey : IRequest<GetprocMaintainancePartsChangeLoadAllListVm>
    {
        public long PartsCange_ID { get; set; }
    }
}
