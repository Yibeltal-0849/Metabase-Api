using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleFuelCount.GetprocVehicleFuelCountLoadAll;

namespace Application.Vehicle.Quiries.procVehicleFuelCount.GetprocVehicleFuelCountByPrimaryKey
{
    /// @author  Shimels Alem proc_Vehicle_FuelCountLoadByPrimaryKey stored procedure.

    public class GetprocVehicleFuelCountByPrimaryKey : IRequest<GetprocVehicleFuelCountLoadAllListVm>
    {
        public System.Guid Vehicle_CountID { get; set; }
    }
}
