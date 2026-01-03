using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalseqoute.GetprocSSalseqouteLoadAll
{
    class GetprocSSalseqouteLoadAllQueryHandler : IRequestHandler<GetprocSSalseqouteLoadAllQuery, GetprocSSalseqouteLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSSalseqouteLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalseqouteLoadAllListVm> Handle(GetprocSSalseqouteLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SSalseQoute> procSSalseqoutes = await _procedureAdabter
               .Execute<SSalseQoute>("[FINA].[proc_S_Salse_qouteLoadAll]");
            GetprocSSalseqouteLoadAllListVm vm = new GetprocSSalseqouteLoadAllListVm
            {
                procSSalseqoutes = _mapper.Map<IList<SSalseQoute>, IList<GetprocSSalseqouteLoadAllVm>>(procSSalseqoutes)
            };

            return vm;
        }
    }
}
