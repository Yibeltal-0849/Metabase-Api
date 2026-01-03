

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.JJPaymentjournal.JJPaymentjournalUpdate.JJPaymentjournalUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXXX stored procedure.
	 
	 
      public class JJPaymentjournalUpdateHandler : IRequestHandler<JJPaymentjournalUpdateCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJPaymentjournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( JJPaymentjournalUpdateCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].XXXXx", request);
           

            return Unit.Value;
        }
    }
}
 