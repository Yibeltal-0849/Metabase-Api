using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Quiries.proctblCompanys.GetproctblCompanysLoadAll;

namespace Application.ProprtyData.Quiries.proctblCompanys.GetproctblCompanysByPrimaryKey
{
    /// @author  Shimels Alem proc_tblCompanysLoadByPrimaryKey stored procedure.

    public class GetproctblCompanysByPrimaryKey : IRequest<GetproctblCompanysLoadAllListVm>
    {
        public long id { get; set; }
    }
}
