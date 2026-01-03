using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAccountProposeInsert.procAccountProposeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Account_ProposeInsert stored procedure.
	 
	 
      public class procAccountProposeInsertHandler : IRequestHandler<procAccountProposeInsertCommand, IList<AccountPropose_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAccountProposeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AccountPropose_Name>> Handle( procAccountProposeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<AccountPropose_Name> result = await _procedureAdabter
                .Execute<AccountPropose_Name>("[FINA].proc_Account_ProposeInsert", request);
           

            return result;
        }
    }
}
 
