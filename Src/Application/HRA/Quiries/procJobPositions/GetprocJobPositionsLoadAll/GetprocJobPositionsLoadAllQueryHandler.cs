using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procJobPositions.GetprocJobPositionsLoadAll
{
    class GetprocJobPositionsLoadAllQueryHandler : IRequestHandler<GetprocJobPositionsLoadAllQuery, GetprocJobPositionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJobPositionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJobPositionsLoadAllListVm> Handle(GetprocJobPositionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JobPositions> procJobPositionss = await _procedureAdabter
               .Execute<JobPositions>("[HRA].[proc_Job_PositionsLoadAll]");
            GetprocJobPositionsLoadAllListVm vm = new GetprocJobPositionsLoadAllListVm
            {
                procJobPositionss = _mapper.Map<IList<JobPositions>, IList<GetprocJobPositionsLoadAllVm>>(procJobPositionss)
            };

            return vm;
        }
    }
}
