using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procIssueDetail.GetprocIssueDetailLoadAll;

namespace Application.Inventory.Quiries.procIssueDetail.GetprocIssueDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_Issue_DetailLoadByPrimaryKey stored procedure.

    public class GetprocIssueDetailByPrimaryKey : IRequest<GetprocIssueDetailLoadAllListVm>
    {
        public long IssueDetail_ID { get; set; }
    }
}
