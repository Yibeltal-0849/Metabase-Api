using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceProduct.GetproctblResourceProductLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceProduct.GetproctblResourceProductByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResource_ProductLoadByPrimaryKey stored procedure.

    public class GetproctblResourceProductByPrimaryKey : IRequest<GetproctblResourceProductLoadAllListVm>
    {
        public long id { get; set; }
    }
}
