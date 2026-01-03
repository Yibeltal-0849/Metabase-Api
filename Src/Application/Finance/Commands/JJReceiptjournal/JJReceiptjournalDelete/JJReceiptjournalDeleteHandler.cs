using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJReceiptjournal.JJReceiptjournalDelete.JJReceiptjournalDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class JJReceiptjournalDeleteHandler : IRequestHandler<JJReceiptjournalDeleteCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJReceiptjournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( JJReceiptjournalDeleteCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].XXXXXXXXX", request);
           

            return Unit.Value;
        }
    }
}
  