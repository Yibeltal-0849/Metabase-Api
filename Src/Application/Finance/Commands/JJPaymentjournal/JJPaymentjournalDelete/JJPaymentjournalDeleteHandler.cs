using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJPaymentjournal.JJPaymentjournalDelete.JJPaymentjournalDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class JJPaymentjournalDeleteHandler : IRequestHandler<JJPaymentjournalDeleteCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJPaymentjournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( JJPaymentjournalDeleteCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].XXXXXXXXX", request);
           

            return Unit.Value;
        }
    }
}
  