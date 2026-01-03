using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procJobPositions.GetprocJobPositionsLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procJobPositions.GetprocJobPositionsByPrimaryKey
{
    public class GetprocJobPositions_departQueryHandler : IRequestHandler<GetprocJobPositionsBydepartementcode, GetprocJobPositionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJobPositions_departQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJobPositionsLoadAllListVm> Handle(GetprocJobPositionsBydepartementcode request, CancellationToken cancellationToken)
        {
           
            IList<JobPositions> procJobPositionss = await _procedureAdabter
               .Execute<JobPositions>("[HRA].[proc_Job_PositionsLoadAll]", request);
            GetprocJobPositionsLoadAllListVm vm = new GetprocJobPositionsLoadAllListVm
            {
                procJobPositionss = _mapper.Map<IList<JobPositions>, IList<GetprocJobPositionsLoadAllVm>>(procJobPositionss)
            };

            return vm;
        }
    }
}
