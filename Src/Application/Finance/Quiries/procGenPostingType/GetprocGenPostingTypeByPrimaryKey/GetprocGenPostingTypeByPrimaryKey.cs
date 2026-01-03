using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procGenPostingType.GetprocGenPostingTypeLoadAll;

namespace Application.Finance.Quiries.procGenPostingType.GetprocGenPostingTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Gen_Posting_TypeLoadByPrimaryKey stored procedure.

    public class GetprocGenPostingTypeByPrimaryKey : IRequest<GetprocGenPostingTypeLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
