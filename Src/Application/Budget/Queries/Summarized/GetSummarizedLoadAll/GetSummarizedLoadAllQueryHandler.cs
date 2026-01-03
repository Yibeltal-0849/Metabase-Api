using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.Summarized.GetSummarizedLoadAll
{
    class GetSummarizedLoadAllQueryHandler : IRequestHandler<GetSummarizedLoadAllQuery, GetSummarizedLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetSummarizedLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetSummarizedLoadAllListVm> Handle(GetSummarizedLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Summarized> Summarizeds = await _procedureAdabter
               .Execute<_Summarized>("[Budget].[proc_SummarizedLoadAll]");
            GetSummarizedLoadAllListVm vm = new GetSummarizedLoadAllListVm
            {
                Summarizeds = _mapper.Map<IList<_Summarized>, IList<GetSummarizedLoadAllVm>>(Summarizeds)
            };

            return vm;
        }
    }
}
