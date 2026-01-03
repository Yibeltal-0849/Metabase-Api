using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.procProportyAndPostion.GetprocProportyAndPostionLoadAll;

namespace Application.ProprtyData.Queries.procProportyAndPostion.GetprocProportyAndPostionByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocProportyAndPostionByPrimaryKey : IRequest<GetprocProportyAndPostionListVm>
    {
        public System.Guid Id { get; set; }

    }
}
