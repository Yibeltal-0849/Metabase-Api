using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceProduction.GetproctblResourceProductionLoadAll
{
    class GetproctblResourceProductionLoadAllQueryHandler : IRequestHandler<GetproctblResourceProductionLoadAllQuery, GetproctblResourceProductionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceProductionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceProductionLoadAllListVm> Handle(GetproctblResourceProductionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceProduction> proctblResourceProductions = await _procedureAdabter
               .Execute<tblResourceProduction>("[ProprtyData].[proc_tblResourceProductionLoadAll]");
            GetproctblResourceProductionLoadAllListVm vm = new GetproctblResourceProductionLoadAllListVm
            {
                proctblResourceProductions = _mapper.Map<IList<tblResourceProduction>, IList<GetproctblResourceProductionLoadAllVm>>(proctblResourceProductions)
            };

            return vm;
        }
    }
}
