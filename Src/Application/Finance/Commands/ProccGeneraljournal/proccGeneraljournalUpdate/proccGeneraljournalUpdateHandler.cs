using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalUpdate.proccGeneraljournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journalUpdate stored procedure.
	 
	 
      public class proccGeneraljournalUpdateHandler : IRequestHandler<proccGeneraljournalUpdateCommand, IList<proccGeneraljournal_account_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccGeneraljournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccGeneraljournal_account_Id>> Handle( proccGeneraljournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<proccGeneraljournal_account_Id> result = await _procedureAdabter
                .Execute<proccGeneraljournal_account_Id>("[FINA].proc_c_General_journalUpdate", request);
           

            return result;
        }
    }
}
 
