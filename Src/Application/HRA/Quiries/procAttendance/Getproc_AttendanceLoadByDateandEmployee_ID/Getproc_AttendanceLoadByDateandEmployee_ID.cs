using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procAttendance.GetprocAttendanceLoadAll;

namespace Application.HRA.Quiries.procAttendance.Getproc_AttendanceLoadByDateandEmployee_ID
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey stored procedure.

    public class Getproc_AttendanceLoadByDateandEmployee_ID : IRequest<GetprocAttendanceLoadAllListVm>
    {
        public DateTime? Date { get; set; }
        public string Employee_ID { get; set; }
    }
}
