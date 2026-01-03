using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceSuppliers.GetproctblResourceSuppliersLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceSuppliers.GetproctblResourceSuppliersByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceSuppliersLoadByPrimaryKey stored procedure.

    public class GetproctblResourceSuppliersByPrimaryKey : IRequest<GetproctblResourceSuppliersLoadAllListVm>
    {
        public long id { get; set; }
    }
}
