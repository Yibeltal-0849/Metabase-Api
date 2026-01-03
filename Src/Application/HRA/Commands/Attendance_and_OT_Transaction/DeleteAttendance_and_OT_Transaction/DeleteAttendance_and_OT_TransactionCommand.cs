using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Attendance_and_OT_Transaction.DeleteAttendance_and_OT_Transaction
{
    /// @author  Shimels Alem  DeleteCAttendance_and_OT_Transaction stored procedure.
    
    public class DeleteAttendance_and_OT_TransactionCommand : IRequest<IList<AttendanceAndOtTransaction_Att_OT_Trans_Id>>
    {
        public Guid Att_OT_Trans_Id { get; set; }
    }
}
