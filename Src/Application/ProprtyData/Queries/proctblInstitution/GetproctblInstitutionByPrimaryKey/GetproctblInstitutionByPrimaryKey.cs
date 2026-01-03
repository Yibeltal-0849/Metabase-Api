using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblInstitution.GetproctblInstitutionLoadAll;

namespace Application.ProprtyData.Queries.proctblInstitution.GetproctblInstitutionByPrimaryKey
{
    /// @author  Shimels Alem proc_tblInstitutionLoadByPrimaryKey stored procedure.

    public class GetproctblInstitutionByPrimaryKey : IRequest<GetproctblInstitutionLoadAllListVm>
    {
        public long id { get; set; }
    }
}
