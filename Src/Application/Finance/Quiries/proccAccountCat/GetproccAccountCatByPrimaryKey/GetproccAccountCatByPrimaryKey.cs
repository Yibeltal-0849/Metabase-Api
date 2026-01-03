using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccAccountCat.GetproccAccountCatLoadAll;

namespace Application.Finance.Quiries.proccAccountCat.GetproccAccountCatByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Account_CatLoadByPrimaryKey stored procedure.

    public class GetproccAccountCatByPrimaryKey : IRequest<GetproccAccountCatLoadAllListVm>
    {
        public int Code { get; set; }
    }
}
