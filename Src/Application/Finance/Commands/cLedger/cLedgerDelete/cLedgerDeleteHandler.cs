using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cLedger.cLedgerDelete.cLedgerDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class cLedgerDeleteHandler : IRequestHandler<cLedgerDeleteCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cLedgerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( cLedgerDeleteCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].XXXXXXXXX", request);
           

            return Unit.Value;
        }
    }
}
  