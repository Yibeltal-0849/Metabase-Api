using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Queries.procVehicleRequestOrder.GetprocVehicleRequestOrderLoadAll;

namespace Application.Vehicle.Queries.procVehicleRequestOrder.GetprocVehicleRequestOrderLoadByPrimaryKey_VehicleRequestID
{
    /// @author  Shimels Alem proc_VehicleRequest_OrderLoadByPrimaryKey_Vehicle_RequestID stored procedure.

    public class GetprocVehicleRequestOrderLoadByPrimaryKey_VehicleRequestID : IRequest<GetprocVehicleRequestOrderLoadAllListVm>
    {
        public System.Guid Vehicle_RequestID { get; set; }
    }
}
