using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.Lkmaster.GetLkmasterLoadAll;

namespace Application.Finance.Quiries.Lkmaster.GetLkmasterByPrimaryKey
{
    /// @author  Shimels Alem  lkmaster_GetRecord stored procedure.

    public class GetLkmasterByPrimaryKey : IRequest<GetLkmasterLoadAllListVm>
    {
            public System.Guid lkmaster_code { get; set; }
    }
}
