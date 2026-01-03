using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procaspnetUsers.GetprocaspnetUsersLoadAll;

namespace Application.dbo.Quiries.procaspnetUsers.GetprocaspnetUsersByPrimaryKey
{
    /// @author  Shimels Alem proc_aspnet_UsersLoadByPrimaryKey stored procedure.

    public class GetprocaspnetUsersByPrimaryKey : IRequest<GetprocaspnetUsersLoadAllListVm>
    {
        public System.Guid UserId { get; set; }
    }
}
