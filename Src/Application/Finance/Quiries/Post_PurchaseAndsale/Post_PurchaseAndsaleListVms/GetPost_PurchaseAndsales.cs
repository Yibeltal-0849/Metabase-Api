using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.Post_PurchaseAndsale.Post_PurchaseAndsaleby;

namespace Application.Finance.Quiries.Post_PurchaseAndsale.Post_PurchaseAndsaleListVms
{
    /// @author  Shimels Alem proc_Bank_Account_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetPost_PurchaseAndsales : IRequest<Post_PurchaseAndsaleListVm>
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public string Application_No { get; set; }
        public Guid UserID { get; set; }
        public Guid TaskId { get; set; }
    }
}
