using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATBusPostingGroupDelete.procVATBusPostingGroupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Bus_Posting_GroupDelete stored procedure.
	 
	 
      public class procVATBusPostingGroupDeleteHandler : IRequestHandler<procVATBusPostingGroupDeleteCommand, IList<procVATBusPostingGroup_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVATBusPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procVATBusPostingGroup_code>> Handle( procVATBusPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<procVATBusPostingGroup_code> result = await _procedureAdabter
                .Execute<procVATBusPostingGroup_code>("[FINA].proc_VAT_Bus_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
 
