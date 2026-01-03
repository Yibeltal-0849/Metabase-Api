using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procDocumentArchive.procDocumentArchiveDelete.procDocumentArchiveDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class procDocumentArchiveDeleteHandler : IRequestHandler<procDocumentArchiveDeleteCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procDocumentArchiveDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( procDocumentArchiveDeleteCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].proc_Document_ArchiveDelete", request);
           

            return Unit.Value;
        }
    }
}
  