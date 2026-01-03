using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procTAXBusPostingGroup.GetprocTAXBusPostingGroupLoadAll;

namespace Application.Inventory.Quiries.procTAXBusPostingGroup.AvalableTaxGroup
{
    // @author  Shimels Alem proc_TAX_Bus_Posting_GroupLoadByPrimaryKey stored procedure.

    public class AvalableTaxGroup : IRequest<GetprocTAXBusPostingGroupLoadAllListVm>
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public Guid Application_No { get; set; }
        public Guid UserID { get; set; }
    }
}
