using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.AttendaceAndOT_Approval.UpdateAttendaceAndOT_Approval
{
    /// @author  Shimels Alem  UpdateCAttendaceAndOT_Approval stored procedure.
    
    public class UpdateAttendaceAndOT_ApprovalCommand : IRequest<IList<AttendaceAndOtApproval_ATT_OT_Trans_ID>>
    {
        public Guid? ATT_OT_Trans_ID { get; set; }
        public bool? IS_Approved { get; set; }
        public Guid? Approved_By { get; set; }
        public string Remark { get; set; }
    }
}
