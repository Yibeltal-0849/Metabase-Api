using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleRequst.GetprocVehicleRequstLoadAll;

namespace Application.Vehicle.Quiries.procVehicleRequst.GetprocVehicleRequstByPrimaryKey
{
    /// @author  Shimels Alem proc_Vehicle_RequstLoadByPrimaryKey stored procedure.

    public class GetprocVehicleRequstByPrimaryKey : IRequest<GetprocVehicleRequstLoadAllListVm>
    {
        public System.Guid Vehicle_RequestID { get; set; }
    }
}
