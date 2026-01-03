using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblVariable.GetproctblVariableLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblVariable.GetproctblVariableByPrimaryKey
{
    public class GetproctblVariableQueryHandler : IRequestHandler<GetproctblVariableByPrimaryKey, GetproctblVariableLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblVariableQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblVariableLoadAllListVm> Handle(GetproctblVariableByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblVariable> proctblVariables = await _procedureAdabter
               .Execute<tblVariable>("[ProprtyData].[proc_tblVariableLoadByPrimaryKey]", request);
            GetproctblVariableLoadAllListVm vm = new GetproctblVariableLoadAllListVm
            {
                proctblVariables = _mapper.Map<IList<tblVariable>, IList<GetproctblVariableLoadAllVm>>(proctblVariables)
            };

            return vm;
        }
    }
}
