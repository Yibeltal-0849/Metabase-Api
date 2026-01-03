using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procVehicleRequst.GetprocVehicleRequstLoadAll;

namespace Application.Vehicle.Quiries.procVehicleRequst.GetprocVehicleRequstLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Vehicle_RequstLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocVehicleRequstLoadByPrimaryKeyApplicationNumber : IRequest<GetprocVehicleRequstLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
