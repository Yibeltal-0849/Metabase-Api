using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblOrganizationType.GetproctblOrganizationTypeLoadAll;

namespace Application.ProprtyData.Queries.proctblOrganizationType.GetproctblOrganizationTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_tblOrganization_TypeLoadByPrimaryKey stored procedure.

    public class GetproctblOrganizationTypeByPrimaryKey : IRequest<GetproctblOrganizationTypeLoadAllListVm>
    {
        public long id { get; set; }
    }
}
