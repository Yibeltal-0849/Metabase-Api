using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicle.GetprocVehicleLoadAll;

namespace Application.Vehicle.Quiries.procVehicle.GetprocVehicleByPrimaryKey
{
    /// @author  Shimels Alem proc_VehicleLoadByPrimaryKey stored procedure.

    public class GetprocVehicleByPrimaryKey : IRequest<GetprocVehicleLoadAllListVm>
    {
        public System.Guid Vehicle_ID { get; set; }
    }
}
