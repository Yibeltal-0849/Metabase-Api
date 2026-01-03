using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCustomerPostingGroup.GetprocCustomerPostingGroupLoadAll
{
    class GetprocCustomerPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocCustomerPostingGroupLoadAllQuery, GetprocCustomerPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCustomerPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCustomerPostingGroupLoadAllListVm> Handle(GetprocCustomerPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CustomerPostingGroup> procCustomerPostingGroups = await _procedureAdabter
               .Execute<CustomerPostingGroup>("[FINA].[proc_Customer_Posting_GroupLoadAll]");
            GetprocCustomerPostingGroupLoadAllListVm vm = new GetprocCustomerPostingGroupLoadAllListVm
            {
                procCustomerPostingGroups = _mapper.Map<IList<CustomerPostingGroup>, IList<GetprocCustomerPostingGroupLoadAllVm>>(procCustomerPostingGroups)
            };

            return vm;
        }
    }
}
