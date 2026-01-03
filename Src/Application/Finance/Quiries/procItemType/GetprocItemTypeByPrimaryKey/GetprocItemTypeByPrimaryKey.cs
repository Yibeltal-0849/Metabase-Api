using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procItemType.GetprocItemTypeLoadAll;

namespace Application.Finance.Quiries.procItemType.GetprocItemTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_ItemTypeLoadByPrimaryKey stored procedure.

    public class GetprocItemTypeByPrimaryKey : IRequest<GetprocItemTypeLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
