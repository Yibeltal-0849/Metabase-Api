using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CEmployee_Pay_Info.GetCEmployeePayInfoLoadAll;

namespace XOKA.Application.HRA.Quiries.CEmployee_Pay_Info.GetCEmployeePayInfoByPrimaryKey
{
    /// @author  Shimels Alem  GetCEmployeePayInfoByPrimaryKey stored procedure.
    
    public class GetCEmployeePayInfoByPrimaryKey : IRequest<GetCEmployeePayInfoLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
