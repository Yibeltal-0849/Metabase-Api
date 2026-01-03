using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Attendance_and_OT_Transaction.CreateAttendance_and_OT_Transaction
{
    /// @author  Shimels Alem  CreateCAttendance_and_OT_Transaction stored procedure.
    
    public class CreateAttendance_and_OT_TransactionCommand : IRequest<IList<AttendanceAndOtTransaction_Att_OT_Trans_Id>>
    {
        public Guid? Att_OT_Trans_Id { get; set; }
        public Guid? Application_Code { get; set; }
        public string Application_No { get; set; }
        public string Period { get; set; }
        public string  Month_Name { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public Guid? organization_code { get; set; }
        public Guid? DIV { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Log { get; set; }
    }
}
