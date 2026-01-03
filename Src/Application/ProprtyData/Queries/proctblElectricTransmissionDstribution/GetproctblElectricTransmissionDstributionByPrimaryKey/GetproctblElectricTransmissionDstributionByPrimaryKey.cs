using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblElectricTransmissionDstribution.GetproctblElectricTransmissionDstributionLoadAll;

namespace Application.ProprtyData.Queries.proctblElectricTransmissionDstribution.GetproctblElectricTransmissionDstributionByPrimaryKey
{
    /// @author  Shimels Alem proc_tblElectric_Transmission_DstributionLoadByPrimaryKey stored procedure.

    public class GetproctblElectricTransmissionDstributionByPrimaryKey : IRequest<GetproctblElectricTransmissionDstributionLoadAllListVm>
    {
        public long id { get; set; }
    }
}
