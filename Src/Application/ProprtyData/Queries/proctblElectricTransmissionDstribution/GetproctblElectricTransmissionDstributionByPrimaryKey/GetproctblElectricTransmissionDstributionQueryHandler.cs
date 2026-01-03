using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblElectricTransmissionDstribution.GetproctblElectricTransmissionDstributionLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblElectricTransmissionDstribution.GetproctblElectricTransmissionDstributionByPrimaryKey
{
    public class GetproctblElectricTransmissionDstributionQueryHandler : IRequestHandler<GetproctblElectricTransmissionDstributionByPrimaryKey, GetproctblElectricTransmissionDstributionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblElectricTransmissionDstributionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblElectricTransmissionDstributionLoadAllListVm> Handle(GetproctblElectricTransmissionDstributionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblElectricTransmissionDstribution> proctblElectricTransmissionDstributions = await _procedureAdabter
               .Execute<tblElectricTransmissionDstribution>("[ProprtyData].[proc_tblElectric_Transmission_DstributionLoadByPrimaryKey]", request);
            GetproctblElectricTransmissionDstributionLoadAllListVm vm = new GetproctblElectricTransmissionDstributionLoadAllListVm
            {
                proctblElectricTransmissionDstributions = _mapper.Map<IList<tblElectricTransmissionDstribution>, IList<GetproctblElectricTransmissionDstributionLoadAllVm>>(proctblElectricTransmissionDstributions)
            };

            return vm;
        }
    }
}
