using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proclkdetail.GetproclkdetailLoadAll;

namespace Application.Finance.Quiries.proclkdetail.GetproclkdetailByPrimaryKey
{
    /// @author  Shimels Alem proc_lkdetailLoadByPrimaryKey stored procedure.

    public class GetproclkdetailByPrimaryKey : IRequest<GetproclkdetailLoadAllListVm>
    {
        public System.Guid lkdetail_Code { get; set; }
    }
}
