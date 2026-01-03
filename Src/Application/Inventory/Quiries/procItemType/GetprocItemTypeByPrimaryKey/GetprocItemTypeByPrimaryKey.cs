using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemType.GetprocItemTypeLoadAll;

namespace Application.Inventory.Quiries.procItemType.GetprocItemTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_ItemTypeLoadByPrimaryKey stored procedure.

    public class GetprocItemTypeByPrimaryKey : IRequest<GetprocItemTypeLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
