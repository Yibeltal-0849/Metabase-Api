using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblVariable.GetproctblVariableLoadAll
{
    class GetproctblVariableLoadAllQueryHandler : IRequestHandler<GetproctblVariableLoadAllQuery, GetproctblVariableLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblVariableLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblVariableLoadAllListVm> Handle(GetproctblVariableLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblVariable> proctblVariables = await _procedureAdabter
               .Execute<tblVariable>("[ProprtyData].[proc_tblVariableLoadAll]");
            GetproctblVariableLoadAllListVm vm = new GetproctblVariableLoadAllListVm
            {
                proctblVariables = _mapper.Map<IList<tblVariable>, IList<GetproctblVariableLoadAllVm>>(proctblVariables)
            };

            return vm;
        }
    }
}
