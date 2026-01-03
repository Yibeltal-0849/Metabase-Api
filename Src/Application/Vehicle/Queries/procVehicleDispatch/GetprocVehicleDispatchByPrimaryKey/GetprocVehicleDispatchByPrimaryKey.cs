using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleDispatch.GetprocVehicleDispatchLoadAll;

namespace Application.Vehicle.Quiries.procVehicleDispatch.GetprocVehicleDispatchByPrimaryKey
{
    /// @author  Shimels Alem proc_Vehicle_DispatchLoadByPrimaryKey stored procedure.

    public class GetprocVehicleDispatchByPrimaryKey : IRequest<GetprocVehicleDispatchLoadAllListVm>
    {
        public System.Guid Vehicle_DispatchID { get; set; }
    }
}
