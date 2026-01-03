using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSSalseqoute.GetprocSSalseqouteLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalseqoute.GetprocSSalseqouteByPrimaryKey
{
    public class GetprocSSalseqouteQueryHandler : IRequestHandler<GetprocSSalseqouteByPrimaryKey, GetprocSSalseqouteLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSSalseqouteQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalseqouteLoadAllListVm> Handle(GetprocSSalseqouteByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SSalseQoute> procSSalseqoutes = await _procedureAdabter
               .Execute<SSalseQoute>("[FINA].[proc_S_Salse_qouteLoadByPrimaryKey]", request);
            GetprocSSalseqouteLoadAllListVm vm = new GetprocSSalseqouteLoadAllListVm
            {
                procSSalseqoutes = _mapper.Map<IList<SSalseQoute>, IList<GetprocSSalseqouteLoadAllVm>>(procSSalseqoutes)
            };

            return vm;
        }
    }
}
