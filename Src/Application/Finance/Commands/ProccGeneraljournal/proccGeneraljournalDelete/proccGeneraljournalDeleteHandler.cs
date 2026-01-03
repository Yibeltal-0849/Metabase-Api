using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalDelete.proccGeneraljournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journalDelete stored procedure.
	 
	 
      public class proccGeneraljournalDeleteHandler : IRequestHandler<proccGeneraljournalDeleteCommand, IList<proccGeneraljournal_account_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccGeneraljournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccGeneraljournal_account_Id>> Handle( proccGeneraljournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<proccGeneraljournal_account_Id> result = await _procedureAdabter
                .Execute<proccGeneraljournal_account_Id>("[FINA].proc_c_General_journalDelete", request);
           

            return result;
        }
    }
}
 
