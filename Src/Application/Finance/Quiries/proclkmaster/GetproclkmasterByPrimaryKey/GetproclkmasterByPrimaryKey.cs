using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proclkmaster.GetproclkmasterLoadAll;

namespace Application.Finance.Quiries.proclkmaster.GetproclkmasterByPrimaryKey
{
    /// @author  Shimels Alem proc_lkmasterLoadByPrimaryKey stored procedure.

    public class GetproclkmasterByPrimaryKey : IRequest<GetproclkmasterLoadAllListVm>
    {
        public System.Guid lkmaster_Code { get; set; }
    }
}
