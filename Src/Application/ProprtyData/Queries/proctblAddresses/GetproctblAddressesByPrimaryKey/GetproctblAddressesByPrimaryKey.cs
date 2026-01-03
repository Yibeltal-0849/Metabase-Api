using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblAddresses.GetproctblAddressesLoadAll;

namespace Application.ProprtyData.Queries.proctblAddresses.GetproctblAddressesByPrimaryKey
{
    /// @author  Shimels Alem proc_tblAddressesLoadByPrimaryKey stored procedure.

    public class GetproctblAddressesByPrimaryKey : IRequest<GetproctblAddressesLoadAllListVm>
    {
        public long id { get; set; }
    }
}
