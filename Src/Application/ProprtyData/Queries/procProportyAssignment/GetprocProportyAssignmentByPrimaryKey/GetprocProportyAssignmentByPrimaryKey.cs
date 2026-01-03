using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procProportyAssignment.GetprocProportyAssignmentLoadAll;

namespace Application.ProprtyData.Queries.procProportyAssignment.GetprocProportyAssignmentByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocProportyAssignmentByPrimaryKey : IRequest<GetprocProportyAssignmentListVm>
    {
        public System.Guid Assig_Id { get; set; }

    }
}
