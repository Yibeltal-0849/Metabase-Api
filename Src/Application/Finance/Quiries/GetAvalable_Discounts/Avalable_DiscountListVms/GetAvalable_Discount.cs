using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.GetAvalable_Discounts.Avalable_Discountby;

namespace Application.Finance.Quiries.Avalable_Discounts.Avalable_DiscountListVms
{
    /// @author  Shimels Alem proc_Bank_Account_Posting_GroupLoadByPrimaryKey stored procedure.

    public class GetAvalable_Discount : IRequest<Avalable_DiscountListVm>
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public Guid Application_No { get; set; }
        public Guid UserID { get; set; }
        
    }
}
