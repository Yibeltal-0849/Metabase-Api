using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccAccountType.GetproccAccountTypeLoadAll;

namespace Application.Finance.Quiries.proccAccountType.GetproccAccountTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Account_TypeLoadByPrimaryKey stored procedure.

    public class GetproccAccountTypeByPrimaryKey : IRequest<GetproccAccountTypeLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
