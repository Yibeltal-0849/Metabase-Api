using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseLoadAll;

namespace Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseByPrimaryKey
{
    /// @author  Shimels Alem proc_Vehicle_LeaseLoadByPrimaryKey stored procedure.

    public class GetprocVehicleLeaseByPrimaryKey : IRequest<GetprocVehicleLeaseLoadAllListVm>
    {
        public System.Guid Vehicle_LeaseID { get; set; }
    }
}
