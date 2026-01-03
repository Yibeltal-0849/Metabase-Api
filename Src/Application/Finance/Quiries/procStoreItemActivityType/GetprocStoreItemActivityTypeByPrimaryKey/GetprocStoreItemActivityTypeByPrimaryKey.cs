using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procStoreItemActivityType.GetprocStoreItemActivityTypeLoadAll;

namespace Application.Finance.Quiries.procStoreItemActivityType.GetprocStoreItemActivityTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Store_Item_Activity_TypeLoadByPrimaryKey stored procedure.

    public class GetprocStoreItemActivityTypeByPrimaryKey : IRequest<GetprocStoreItemActivityTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
