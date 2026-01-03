using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleLeaseTo.GetprocVehicleLeaseToLoadAll;

namespace Application.Vehicle.Quiries.procVehicleLeaseTo.GetprocVehicleLeaseToByPrimaryKey
{
    /// @author  Shimels Alem proc_Vehicle_LeaseToLoadByPrimaryKey stored procedure.

    public class GetprocVehicleLeaseToByPrimaryKey : IRequest<GetprocVehicleLeaseToLoadAllListVm>
    {
        public System.Guid Vehicle_LeaseToID { get; set; }
    }
}
