using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Summarized.SummarizedDelete.SummarizedDeleteCommand
{ 	 
	 
      public class SummarizedDeleteHandler : IRequestHandler<SummarizedDeleteCommand, IList<_Summarized_Budget_Summarized_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SummarizedDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Summarized_Budget_Summarized_ID>> Handle( SummarizedDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<_Summarized_Budget_Summarized_ID> result = await _procedureAdabter
                .Execute<_Summarized_Budget_Summarized_ID>("[Budget].SummarizedDelete", request);
           

            return result;
        }
    }
}
 
