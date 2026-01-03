using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCustomerPostingGroup.GetprocCustomerPostingGroupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCustomerPostingGroup.GetprocCustomerPostingGroupByPrimaryKey
{
    public class GetprocCustomerPostingGroupQueryHandler : IRequestHandler<GetprocCustomerPostingGroupByPrimaryKey, GetprocCustomerPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCustomerPostingGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCustomerPostingGroupLoadAllListVm> Handle(GetprocCustomerPostingGroupByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CustomerPostingGroup> procCustomerPostingGroups = await _procedureAdabter
               .Execute<CustomerPostingGroup>("[FINA].[proc_Customer_Posting_GroupLoadByPrimaryKey]", request);
            GetprocCustomerPostingGroupLoadAllListVm vm = new GetprocCustomerPostingGroupLoadAllListVm
            {
                procCustomerPostingGroups = _mapper.Map<IList<CustomerPostingGroup>, IList<GetprocCustomerPostingGroupLoadAllVm>>(procCustomerPostingGroups)
            };

            return vm;
        }
    }
}
