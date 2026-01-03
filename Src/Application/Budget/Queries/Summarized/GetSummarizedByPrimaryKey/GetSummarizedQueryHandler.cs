using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Budget.Queries.Summarized.GetSummarizedLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Queries.Summarized.GetSummarizedByPrimaryKey
{
    public class GetSummarizedQueryHandler : IRequestHandler<GetSummarizedByPrimaryKey, GetSummarizedLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetSummarizedQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetSummarizedLoadAllListVm> Handle(GetSummarizedByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_Summarized> Summarizeds = await _procedureAdabter
               .Execute<_Summarized>("[Budget].[proc_SummarizedLoadByPrimaryKey]", request);
            GetSummarizedLoadAllListVm vm = new GetSummarizedLoadAllListVm
            {
                Summarizeds = _mapper.Map<IList<_Summarized>, IList<GetSummarizedLoadAllVm>>(Summarizeds)
            };

            return vm;
        }
    }
}
