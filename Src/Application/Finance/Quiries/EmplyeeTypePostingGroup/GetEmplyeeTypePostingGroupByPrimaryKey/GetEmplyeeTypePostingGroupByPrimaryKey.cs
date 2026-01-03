using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.EmplyeeTypePostingGroup.GetEmplyeeTypePostingGroupLoadAll;

namespace Application.Finance.Quiries.EmplyeeTypePostingGroup.GetEmplyeeTypePostingGroupByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Account_CatLoadByPrimaryKey stored procedure.

    public class GetEmplyeeTypePostingGroupByPrimaryKey : IRequest<GetEmplyeeTypePostingGroupLoadAllListVm>
    {
        public String Code { get; set; }
    }
}
