using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGenProductPostingGroupUpdate.procGenProductPostingGroupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Gen_Product_Posting_GroupUpdate stored procedure.
	 
	 
      public class procGenProductPostingGroupUpdateHandler : IRequestHandler<procGenProductPostingGroupUpdateCommand, IList<procGenProductPostingGroup_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGenProductPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procGenProductPostingGroup_code>> Handle( procGenProductPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<procGenProductPostingGroup_code> result = await _procedureAdabter
                .Execute<procGenProductPostingGroup_code>("[FINA].proc_Gen_Product_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 
