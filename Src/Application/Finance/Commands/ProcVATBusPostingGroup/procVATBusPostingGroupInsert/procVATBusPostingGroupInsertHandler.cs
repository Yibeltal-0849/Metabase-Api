using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVATBusPostingGroupInsert.procVATBusPostingGroupInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_VAT_Bus_Posting_GroupInsert stored procedure.
	 
	 
      public class procVATBusPostingGroupInsertHandler : IRequestHandler<procVATBusPostingGroupInsertCommand, IList<procVATBusPostingGroup_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVATBusPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procVATBusPostingGroup_code>> Handle( procVATBusPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<procVATBusPostingGroup_code> result = await _procedureAdabter
                .Execute<procVATBusPostingGroup_code>("[FINA].proc_VAT_Bus_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 
