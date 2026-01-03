



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procDocumentArchive.procDocumentArchiveInsert.procDocumentArchiveInsertCommand
{

    /// @author  Shimels Alem  proc_Document_ArchiveInsert stored procedure.


    public class procDocumentArchiveInsertHandler : IRequestHandler<procDocumentArchiveInsertCommand>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procDocumentArchiveInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Unit> Handle( procDocumentArchiveInsertCommand request, CancellationToken cancellationToken)
        { 

            object result = await _procedureAdabter
                .Execute<object>("[FINA].proc_Document_ArchiveInsert", request);
           

            return Unit.Value;
        }
    }
}
 