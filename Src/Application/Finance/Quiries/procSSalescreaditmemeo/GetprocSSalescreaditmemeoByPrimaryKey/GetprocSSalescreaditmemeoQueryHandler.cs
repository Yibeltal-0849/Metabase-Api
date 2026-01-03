using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSSalescreaditmemeo.GetprocSSalescreaditmemeoLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalescreaditmemeo.GetprocSSalescreaditmemeoByPrimaryKey
{
    public class GetprocSSalescreaditmemeoQueryHandler : IRequestHandler<GetprocSSalescreaditmemeoByPrimaryKey, GetprocSSalescreaditmemeoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSSalescreaditmemeoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalescreaditmemeoLoadAllListVm> Handle(GetprocSSalescreaditmemeoByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SSalesCreaditMemeo> procSSalescreaditmemeos = await _procedureAdabter
               .Execute<SSalesCreaditMemeo>("[FINA].[proc_S_Sales_creadit_memeoLoadByPrimaryKey]", request);
            GetprocSSalescreaditmemeoLoadAllListVm vm = new GetprocSSalescreaditmemeoLoadAllListVm
            {
                procSSalescreaditmemeos = _mapper.Map<IList<SSalesCreaditMemeo>, IList<GetprocSSalescreaditmemeoLoadAllVm>>(procSSalescreaditmemeos)
            };

            return vm;
        }
    }
}
