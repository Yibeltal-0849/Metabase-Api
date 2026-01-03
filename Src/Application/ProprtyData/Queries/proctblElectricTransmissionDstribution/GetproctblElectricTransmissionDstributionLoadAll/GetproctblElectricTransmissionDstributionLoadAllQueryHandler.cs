using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblElectricTransmissionDstribution.GetproctblElectricTransmissionDstributionLoadAll
{
    class GetproctblElectricTransmissionDstributionLoadAllQueryHandler : IRequestHandler<GetproctblElectricTransmissionDstributionLoadAllQuery, GetproctblElectricTransmissionDstributionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblElectricTransmissionDstributionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblElectricTransmissionDstributionLoadAllListVm> Handle(GetproctblElectricTransmissionDstributionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblElectricTransmissionDstribution> proctblElectricTransmissionDstributions = await _procedureAdabter
               .Execute<tblElectricTransmissionDstribution>("[ProprtyData].[proc_tblElectric_Transmission_DstributionLoadAll]");
            GetproctblElectricTransmissionDstributionLoadAllListVm vm = new GetproctblElectricTransmissionDstributionLoadAllListVm
            {
                proctblElectricTransmissionDstributions = _mapper.Map<IList<tblElectricTransmissionDstribution>, IList<GetproctblElectricTransmissionDstributionLoadAllVm>>(proctblElectricTransmissionDstributions)
            };

            return vm;
        }
    }
}
