using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalescreaditmemeo.GetprocSSalescreaditmemeoLoadAll
{
    class GetprocSSalescreaditmemeoLoadAllQueryHandler : IRequestHandler<GetprocSSalescreaditmemeoLoadAllQuery, GetprocSSalescreaditmemeoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSSalescreaditmemeoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalescreaditmemeoLoadAllListVm> Handle(GetprocSSalescreaditmemeoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SSalesCreaditMemeo> procSSalescreaditmemeos = await _procedureAdabter
               .Execute<SSalesCreaditMemeo>("[FINA].[proc_S_Sales_creadit_memeoLoadAll]");
            GetprocSSalescreaditmemeoLoadAllListVm vm = new GetprocSSalescreaditmemeoLoadAllListVm
            {
                procSSalescreaditmemeos = _mapper.Map<IList<SSalesCreaditMemeo>, IList<GetprocSSalescreaditmemeoLoadAllVm>>(procSSalescreaditmemeos)
            };

            return vm;
        }
    }
}
