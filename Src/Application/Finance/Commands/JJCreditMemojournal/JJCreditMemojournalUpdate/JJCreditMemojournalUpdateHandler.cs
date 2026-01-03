

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.JJCreditMemojournal.JJCreditMemojournalUpdate.JJCreditMemojournalUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXXX stored procedure.
	 
	 
      public class JJCreditMemojournalUpdateHandler : IRequestHandler<JJCreditMemojournalUpdateCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJCreditMemojournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( JJCreditMemojournalUpdateCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].XXXXx", request);
           

            return Unit.Value;
        }
    }
}
 