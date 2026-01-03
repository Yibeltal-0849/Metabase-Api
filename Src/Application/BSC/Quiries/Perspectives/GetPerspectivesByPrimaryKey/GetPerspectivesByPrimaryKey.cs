using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.Perspectives.GetPerspectivesLoadAll;

namespace Application.BSC.Quiries.Perspectives.GetPerspectivesByPrimaryKey
{
    /// @author  Shimels Alem  proc_PerspectivesLoadByPrimaryKey stored procedure.

    public class GetPerspectivesByPrimaryKey : IRequest<GetPerspectivesLoadAllListVm>
    {
        public string Perspective_ID { get; set; }
    }
}
