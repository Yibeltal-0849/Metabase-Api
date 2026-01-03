using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATProdPostingGroupInsert.procVATProdPostingGroupInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Prod_Posting_GroupInsert stored procedure.
	 
	 
      public class procVATProdPostingGroupInsertHandler : IRequestHandler<procVATProdPostingGroupInsertCommand, IList<procVATProdPostingGroup_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVATProdPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procVATProdPostingGroup_code>> Handle( procVATProdPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<procVATProdPostingGroup_code> result = await _procedureAdabter
                .Execute<procVATProdPostingGroup_code>("[FINA].proc_VAT_Prod_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 
