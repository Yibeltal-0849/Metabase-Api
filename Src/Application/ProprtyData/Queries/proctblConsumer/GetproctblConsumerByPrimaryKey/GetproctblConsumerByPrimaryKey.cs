using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblConsumer.GetproctblConsumerLoadAll;

namespace Application.ProprtyData.Queries.proctblConsumer.GetproctblConsumerByPrimaryKey
{
    /// @author  Shimels Alem proc_tblConsumerLoadByPrimaryKey stored procedure.

    public class GetproctblConsumerByPrimaryKey : IRequest<GetproctblConsumerLoadAllListVm>
    {
        public long id { get; set; }
    }
}
