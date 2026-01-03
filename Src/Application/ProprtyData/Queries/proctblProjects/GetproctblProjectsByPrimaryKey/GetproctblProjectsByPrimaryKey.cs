using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Quiries.proctblProjects.GetproctblProjectsLoadAll;

namespace Application.ProprtyData.Quiries.proctblProjects.GetproctblProjectsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblProjectsLoadByPrimaryKey stored procedure.

    public class GetproctblProjectsByPrimaryKey : IRequest<GetproctblProjectsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
