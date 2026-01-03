using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFaclitiyDescription.GetproctblFaclitiyDescriptionLoadAll
{
    class GetproctblFaclitiyDescriptionLoadAllQueryHandler : IRequestHandler<GetproctblFaclitiyDescriptionLoadAllQuery, GetproctblFaclitiyDescriptionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblFaclitiyDescriptionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFaclitiyDescriptionLoadAllListVm> Handle(GetproctblFaclitiyDescriptionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblFaclitiyDescription> proctblFaclitiyDescriptions = await _procedureAdabter
               .Execute<tblFaclitiyDescription>("[ProprtyData].[proc_tblFaclitiy_DescriptionLoadAll]");
            GetproctblFaclitiyDescriptionLoadAllListVm vm = new GetproctblFaclitiyDescriptionLoadAllListVm
            {
                proctblFaclitiyDescriptions = _mapper.Map<IList<tblFaclitiyDescription>, IList<GetproctblFaclitiyDescriptionLoadAllVm>>(proctblFaclitiyDescriptions)
            };

            return vm;
        }
    }
}
