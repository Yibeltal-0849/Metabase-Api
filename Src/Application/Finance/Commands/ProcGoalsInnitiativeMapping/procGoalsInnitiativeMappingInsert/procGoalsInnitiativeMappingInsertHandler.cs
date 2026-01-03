using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGoalsInnitiativeMappingInsert.procGoalsInnitiativeMappingInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Goals_Innitiative_MappingInsert stored procedure.
	 
	 
      public class procGoalsInnitiativeMappingInsertHandler : IRequestHandler<procGoalsInnitiativeMappingInsertCommand, IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGoalsInnitiativeMappingInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>> Handle( procGoalsInnitiativeMappingInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID> result = await _procedureAdabter
                .Execute<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>("[FINA].proc_Goals_Innitiative_MappingInsert", request);
           

            return result;
        }
    }
}
 
