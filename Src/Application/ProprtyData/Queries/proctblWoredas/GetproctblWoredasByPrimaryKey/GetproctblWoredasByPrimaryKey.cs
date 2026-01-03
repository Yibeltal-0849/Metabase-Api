using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblWoredas.GetproctblWoredasLoadAll;

namespace Application.ProprtyData.Queries.proctblWoredas.GetproctblWoredasByPrimaryKey
{
    /// @author  Shimels Alem proc_tblWoredasLoadByPrimaryKey stored procedure.

    public class GetproctblWoredasByPrimaryKey : IRequest<GetproctblWoredasLoadAllListVm>
    {
        public long id { get; set; }
    }
}
