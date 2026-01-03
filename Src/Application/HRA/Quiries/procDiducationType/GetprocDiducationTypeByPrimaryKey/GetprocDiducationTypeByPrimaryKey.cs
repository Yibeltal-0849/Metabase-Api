using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procDiducationType.GetprocDiducationTypeLoadAll;

namespace Application.HRA.Quiries.procDiducationType.GetprocDiducationTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Diducation_TypeLoadByPrimaryKey stored procedure.

    public class GetprocDiducationTypeByPrimaryKey : IRequest<GetprocDiducationTypeLoadAllListVm>
    {
        public string DiductionCode { get; set; }
    }
}
