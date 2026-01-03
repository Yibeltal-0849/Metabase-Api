using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procdocumenttypes.GetprocdocumenttypesLoadAll;

namespace Application.Finance.Quiries.procdocumenttypes.GetprocdocumenttypesByPrimaryKey
{
    /// @author  Shimels Alem proc_document_typesLoadByPrimaryKey stored procedure.

    public class GetprocdocumenttypesByPrimaryKey : IRequest<GetprocdocumenttypesLoadAllListVm>
    {
        public System.Guid document_type_code { get; set; }
    }
}
