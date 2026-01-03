

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblElectricTransmissionDstribution.proctblElectricTransmissionDstributionUpdate.proctblElectricTransmissionDstributionUpdateCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Transmission_DstributionUpdate stored procedure.


    public class proctblElectricTransmissionDstributionUpdateHandler : IRequestHandler<proctblElectricTransmissionDstributionUpdateCommand, IList<tblElectricTransmissionDstribution_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblElectricTransmissionDstributionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblElectricTransmissionDstribution_id>> Handle( proctblElectricTransmissionDstributionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblElectricTransmissionDstribution_id> result = await _procedureAdabter
                .Execute<tblElectricTransmissionDstribution_id>("[ProprtyData].proc_tblElectric_Transmission_DstributionUpdate", request);
           

            return result;
        }
    }
}
 