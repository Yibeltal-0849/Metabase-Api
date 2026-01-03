using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Vehicle.Queries.procVehicleRequestOrder.GetprocVehicleRequestOrderLoadAll
{
    /// @author  Shimels Alem  proc_VehicleRequest_OrderLoadAll stored procedure.

    public class GetprocVehicleRequestOrderLoadAllListVm
    {
        public IList<GetprocVehicleRequestOrderLoadAllVm> procVehicleRequestOrders { get; set; }
    }
}
