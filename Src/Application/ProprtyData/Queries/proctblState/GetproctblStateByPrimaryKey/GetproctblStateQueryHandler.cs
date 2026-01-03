using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblState.GetproctblStateLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblState.GetproctblStateByPrimaryKey
{
    public class GetproctblStateQueryHandler : IRequestHandler<GetproctblStateByPrimaryKey, GetproctblStateLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblStateQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblStateLoadAllListVm> Handle(GetproctblStateByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblState> proctblStates = await _procedureAdabter
               .Execute<tblState>("[ProprtyData].[proc_tblStateLoadByPrimaryKey]", request);
            GetproctblStateLoadAllListVm vm = new GetproctblStateLoadAllListVm
            {
                proctblStates = _mapper.Map<IList<tblState>, IList<GetproctblStateLoadAllVm>>(proctblStates)
            };

            return vm;
        }
    }
}
