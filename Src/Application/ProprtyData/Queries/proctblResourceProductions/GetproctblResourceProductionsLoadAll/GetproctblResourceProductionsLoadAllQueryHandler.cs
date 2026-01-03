using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceProductions.GetproctblResourceProductionsLoadAll
{
    class GetproctblResourceProductionsLoadAllQueryHandler : IRequestHandler<GetproctblResourceProductionsLoadAllQuery, GetproctblResourceProductionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceProductionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceProductionsLoadAllListVm> Handle(GetproctblResourceProductionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceProductions> proctblResourceProductionss = await _procedureAdabter
               .Execute<tblResourceProductions>("[ProprtyData].[proc_tblResourceProductionsLoadAll]");
            GetproctblResourceProductionsLoadAllListVm vm = new GetproctblResourceProductionsLoadAllListVm
            {
                proctblResourceProductionss = _mapper.Map<IList<tblResourceProductions>, IList<GetproctblResourceProductionsLoadAllVm>>(proctblResourceProductionss)
            };

            return vm;
        }
    }
}
