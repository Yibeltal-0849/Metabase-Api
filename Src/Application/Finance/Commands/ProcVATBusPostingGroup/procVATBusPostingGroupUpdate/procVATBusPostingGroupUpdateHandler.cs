using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATBusPostingGroupUpdate.procVATBusPostingGroupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Bus_Posting_GroupUpdate stored procedure.
	 
	 
      public class procVATBusPostingGroupUpdateHandler : IRequestHandler<procVATBusPostingGroupUpdateCommand, IList<procVATBusPostingGroup_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVATBusPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procVATBusPostingGroup_code>> Handle( procVATBusPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<procVATBusPostingGroup_code> result = await _procedureAdabter
                .Execute<procVATBusPostingGroup_code>("[FINA].proc_VAT_Bus_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 
