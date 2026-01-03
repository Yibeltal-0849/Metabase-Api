using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadAll;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityByPrimaryApplicationCode
{
    public class GetprocItemActivityByApplicationCode : IRequest<GetprocItemActivityLoadAllListVm>
    {
        public System.Guid Application_Code { get; set; }
    }
}
