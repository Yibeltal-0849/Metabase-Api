using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceBuyers.GetproctblResourceBuyersLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceBuyers.GetproctblResourceBuyersByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceBuyersLoadByPrimaryKey stored procedure.

    public class GetproctblResourceBuyersByPrimaryKey : IRequest<GetproctblResourceBuyersLoadAllListVm>
    {
        public long id { get; set; }
    }
}
