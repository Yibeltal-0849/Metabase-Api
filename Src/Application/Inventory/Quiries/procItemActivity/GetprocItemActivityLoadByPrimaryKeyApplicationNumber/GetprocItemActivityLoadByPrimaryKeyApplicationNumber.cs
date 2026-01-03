using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadAll;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Item_ActivityLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocItemActivityLoadByPrimaryKeyApplicationNumber : IRequest<GetprocItemActivityLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
