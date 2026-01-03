using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblStackHolder.GetproctblStackHolderLoadAll;

namespace Application.ProprtyData.Queries.proctblStackHolder.GetproctblStackHolderByPrimaryKey
{
    /// @author  Shimels Alem proc_tblStackHolderLoadByPrimaryKey stored procedure.

    public class GetproctblStackHolderByPrimaryKey : IRequest<GetproctblStackHolderLoadAllListVm>
    {
        public long id { get; set; }
    }
}
