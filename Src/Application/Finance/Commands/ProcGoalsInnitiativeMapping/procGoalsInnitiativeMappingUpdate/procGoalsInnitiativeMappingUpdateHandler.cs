using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGoalsInnitiativeMappingUpdate.procGoalsInnitiativeMappingUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Goals_Innitiative_MappingUpdate stored procedure.
	 
	 
      public class procGoalsInnitiativeMappingUpdateHandler : IRequestHandler<procGoalsInnitiativeMappingUpdateCommand, IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGoalsInnitiativeMappingUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>> Handle( procGoalsInnitiativeMappingUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID> result = await _procedureAdabter
                .Execute<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>("[FINA].proc_Goals_Innitiative_MappingUpdate", request);
           

            return result;
        }
    }
}
 
