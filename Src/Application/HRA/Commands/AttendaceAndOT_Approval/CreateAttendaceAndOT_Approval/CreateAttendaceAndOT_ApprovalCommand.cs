using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.AttendaceAndOT_Approval.CreateAttendaceAndOT_Approval
{
    /// @author  Shimels Alem  CreateCAttendaceAndOT_Approval stored procedure.
    
    public class CreateAttendaceAndOT_ApprovalCommand : IRequest<IList<AttendaceAndOtApproval_ATT_OT_Trans_ID>>
    {
        public Guid? ATT_OT_Trans_ID { get; set; }
        public bool? IS_Approved { get; set; }
        public Guid? Approved_By { get; set; }
        public string Remark { get; set; }
    }
}
