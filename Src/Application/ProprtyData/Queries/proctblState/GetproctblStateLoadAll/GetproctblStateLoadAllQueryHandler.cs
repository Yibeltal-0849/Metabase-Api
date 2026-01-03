using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblState.GetproctblStateLoadAll
{
    class GetproctblStateLoadAllQueryHandler : IRequestHandler<GetproctblStateLoadAllQuery, GetproctblStateLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblStateLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblStateLoadAllListVm> Handle(GetproctblStateLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblState> proctblStates = await _procedureAdabter
               .Execute<tblState>("[ProprtyData].[proc_tblStateLoadAll]");
            GetproctblStateLoadAllListVm vm = new GetproctblStateLoadAllListVm
            {
                proctblStates = _mapper.Map<IList<tblState>, IList<GetproctblStateLoadAllVm>>(proctblStates)
            };

            return vm;
        }
    }
}
