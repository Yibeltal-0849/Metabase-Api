using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalseorder.GetprocSSalseorderLoadAll
{
    class GetprocSSalseorderLoadAllQueryHandler : IRequestHandler<GetprocSSalseorderLoadAllQuery, GetprocSSalseorderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSSalseorderLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalseorderLoadAllListVm> Handle(GetprocSSalseorderLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SSalseOrder> procSSalseorders = await _procedureAdabter
               .Execute<SSalseOrder>("[FINA].[proc_S_Salse_orderLoadAll]");
            GetprocSSalseorderLoadAllListVm vm = new GetprocSSalseorderLoadAllListVm
            {
                procSSalseorders = _mapper.Map<IList<SSalseOrder>, IList<GetprocSSalseorderLoadAllVm>>(procSSalseorders)
            };

            return vm;
        }
    }
}
