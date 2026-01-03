using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procActiveVehicle.GetprocActiveVehicleLoadAll;

namespace Application.Vehicle.Quiries.procActiveVehicle.GetprocActiveVehicleByPrimaryKey
{
    /// @author  Shimels Alem proc_Active_VehicleLoadByPrimaryKey stored procedure.

    public class GetprocActiveVehicleByPrimaryKey : IRequest<GetprocActiveVehicleLoadAllListVm>
    {
        public System.Guid ActiveVehicle_ID { get; set; }
    }
}
