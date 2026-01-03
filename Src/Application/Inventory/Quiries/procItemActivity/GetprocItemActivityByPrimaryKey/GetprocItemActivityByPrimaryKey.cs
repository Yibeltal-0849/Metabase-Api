using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadAll;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityByPrimaryKey
{
    /// @author  Shimels Alem proc_Item_ActivityLoadByPrimaryKey stored procedure.

    public class GetprocItemActivityByPrimaryKey : IRequest<GetprocItemActivityLoadAllListVm>
    {
        public string Vocher_NO { get; set; }
    }
}
