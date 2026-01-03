using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblElectricTransmissionDstribution.proctblElectricTransmissionDstributionDelete.proctblElectricTransmissionDstributionDeleteCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Transmission_DstributionDelete stored procedure.


    public class proctblElectricTransmissionDstributionDeleteHandler : IRequestHandler<proctblElectricTransmissionDstributionDeleteCommand, IList<tblElectricTransmissionDstribution_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblElectricTransmissionDstributionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblElectricTransmissionDstribution_id>> Handle( proctblElectricTransmissionDstributionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblElectricTransmissionDstribution_id> result = await _procedureAdabter
                .Execute<tblElectricTransmissionDstribution_id>("[ProprtyData].proc_tblElectric_Transmission_DstributionDelete", request);
           

            return result;
        }
    }
}
  