using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Summarized.SummarizedUpdate.SummarizedUpdateCommand
{ 

      public class SummarizedUpdateHandler : IRequestHandler<SummarizedUpdateCommand, IList<_Summarized_Budget_Summarized_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SummarizedUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Summarized_Budget_Summarized_ID>> Handle( SummarizedUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<_Summarized_Budget_Summarized_ID> result = await _procedureAdabter
                .Execute<_Summarized_Budget_Summarized_ID>("[Budget].SummarizedUpdate", request);
           
            return result;
        }
    }
}
 
