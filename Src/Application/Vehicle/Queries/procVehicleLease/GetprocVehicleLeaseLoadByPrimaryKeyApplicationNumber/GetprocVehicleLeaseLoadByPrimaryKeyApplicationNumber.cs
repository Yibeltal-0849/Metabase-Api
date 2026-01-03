using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseLoadAll;

namespace Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Vehicle_LeaseLoadByPrimaryKey stored procedure.

    public class GetprocVehicleLeaseLoadByPrimaryKeyApplicationNumber : IRequest<GetprocVehicleLeaseLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
