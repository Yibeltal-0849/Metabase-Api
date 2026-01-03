using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATProdPostingGroupUpdate.procVATProdPostingGroupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Prod_Posting_GroupUpdate stored procedure.
	 
	 
      public class procVATProdPostingGroupUpdateHandler : IRequestHandler<procVATProdPostingGroupUpdateCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVATProdPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( procVATProdPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].proc_VAT_Prod_Posting_GroupUpdate", request);
           

            return Unit.Value;
        }
    }
}
 
