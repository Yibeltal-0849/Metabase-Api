using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATProdPostingGroupDelete.procVATProdPostingGroupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Prod_Posting_GroupDelete stored procedure.
	 
	 
      public class procVATProdPostingGroupDeleteHandler : IRequestHandler<procVATProdPostingGroupDeleteCommand, IList<procVATProdPostingGroup_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVATProdPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procVATProdPostingGroup_code>> Handle( procVATProdPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<procVATProdPostingGroup_code> result = await _procedureAdabter
                .Execute<procVATProdPostingGroup_code>("[FINA].proc_VAT_Prod_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
 
