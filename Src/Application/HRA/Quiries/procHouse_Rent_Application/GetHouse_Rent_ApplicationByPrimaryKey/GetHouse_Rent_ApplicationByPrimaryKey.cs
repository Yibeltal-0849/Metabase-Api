using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.procHouse_Rent_Application.GetHouse_Rent_ApplicationLoadAll;

namespace XOKA.Application.HRA.Quiries.procHouse_Rent_Application.GetHouse_Rent_ApplicationByPrimaryKey
{
    /// @author  Shimels Alem  proc_Attendance_and_OT_TransactionLoadByPrimaryKey stored procedure.

    public class GetHouse_Rent_ApplicationByPrimaryKey : IRequest<GetHouse_Rent_ApplicationLoadAllListVm>
    {
        public System.Guid Rent_App_ID { get; set; }
      
    }
}
