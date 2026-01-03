using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.ProcProportyStaticData.GetprocProcProportyStaticDataLoadAll;

namespace Application.ProprtyData.Queries.procProportyStaticData.GetprocProportyStaticDataByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_CollectionLoadByPrimaryKey stored procedure.

    public class GetprocProportyStaticDataByPrimaryKey : IRequest<GetprocProcProportyStaticDataLoadAllListVm>
    {
        public System.Guid ID { get; set; }
       
    }
}
