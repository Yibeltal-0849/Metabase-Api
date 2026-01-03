using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccEmployeePayInfo.GetproccEmployeePayInfoLoadAll;

namespace Application.Finance.Quiries.proccEmployeePayInfo.GetproccEmployeePayInfoByPrimaryKey
{
    /// @author  Shimels Alem proc_c_EmployeePayInfoLoadByPrimaryKey stored procedure.

    public class GetproccEmployeePayInfoByPrimaryKey : IRequest<GetproccEmployeePayInfoLoadAllListVm>
    {
        public long id { get; set; }
    }
}
