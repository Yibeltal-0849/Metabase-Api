using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalInsert.proccGeneraljournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journalInsert stored procedure.
	 
	 
      public class proccGeneraljournalInsertHandler : IRequestHandler<proccGeneraljournalInsertCommand, IList<proccGeneraljournal_account_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccGeneraljournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccGeneraljournal_account_Id>> Handle( proccGeneraljournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<proccGeneraljournal_account_Id> result = await _procedureAdabter
                .Execute<proccGeneraljournal_account_Id>("[FINA].proc_c_General_journalInsert", request);
           

            return result;
        }
    }
}
 
