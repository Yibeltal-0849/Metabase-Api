using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.Lkdetail.GetLkdetailLoadAll;

namespace Application.Finance.Quiries.Lkdetail.GetLkdetailByPrimaryKey
{
    /// @author  Shimels Alem  lkdetail_GetRecord stored procedure.

    public class GetLkdetailByPrimaryKey : IRequest<GetLkdetailLoadAllListVm>
    {
            public System.Guid lkdetail_Code { get; set; }
    }
}
