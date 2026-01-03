using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGenPostingTypeUpdate.procGenPostingTypeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Gen_Posting_TypeUpdate stored procedure.
	 
	 
      public class procGenPostingTypeUpdateHandler : IRequestHandler<procGenPostingTypeUpdateCommand, IList<procGenPostingType_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGenPostingTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procGenPostingType_code>> Handle( procGenPostingTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<procGenPostingType_code> result = await _procedureAdabter
                .Execute<procGenPostingType_code>("[FINA].proc_Gen_Posting_TypeUpdate", request);
           

            return result;
        }
    }
}
 
