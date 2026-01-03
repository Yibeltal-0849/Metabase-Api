using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadByOrgCode
{
    public class GetprocItemActivityLoadByOrgnizationCode : IRequest<GetprocItemActivityLoadAllOrgCodeListVm>
    {
        public System.Guid Orgnization_Code { get; set; }
    }
}
