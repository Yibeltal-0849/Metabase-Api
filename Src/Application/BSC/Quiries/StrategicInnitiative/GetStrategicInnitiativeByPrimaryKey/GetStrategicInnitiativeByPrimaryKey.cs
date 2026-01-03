using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.StrategicInnitiative.GetStrategicInnitiativeLoadAll;

namespace Application.BSC.Quiries.StrategicInnitiative.GetStrategicInnitiativeByPrimaryKey
{
    /// @author  Shimels Alem  proc_Strategic_InnitiativeLoadByPrimaryKey stored procedure.

    public class GetStrategicInnitiativeByPrimaryKey : IRequest<GetStrategicInnitiativeLoadAllListVm>
    {
        public string Innitiative_ID { get; set; }
    }
}
