using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procIssueDetail.GetprocIssueDetailLoadAll
{
    class GetprocIssueDetailLoadAllQueryHandler : IRequestHandler<GetprocIssueDetailLoadAllQuery, GetprocIssueDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocIssueDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocIssueDetailLoadAllListVm> Handle(GetprocIssueDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<IssueDetail> procIssueDetails = await _procedureAdabter
               .Execute<IssueDetail>("[Inventory].[proc_Issue_DetailLoadAll]");
            GetprocIssueDetailLoadAllListVm vm = new GetprocIssueDetailLoadAllListVm
            {
                procIssueDetails = _mapper.Map<IList<IssueDetail>, IList<GetprocIssueDetailLoadAllVm>>(procIssueDetails)
            };

            return vm;
        }
    }
}
