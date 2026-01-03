



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;


namespace Application.Document.Commands.DocumentArchive.DocumentArchiveInsert.DocumentArchiveInsertCommand
{

    /// @author  Shimels Alem  Document_ArchiveInsert stored procedure.


    public class DocumentArchiveInsertHandler : IRequestHandler<DocumentArchiveInsertCommand, IList<DocumentArchive_Document_Number>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DocumentArchiveInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DocumentArchive_Document_Number>> Handle( DocumentArchiveInsertCommand request, CancellationToken cancellationToken)
        {

            IList<DocumentArchive_Document_Number> result = await _procedureAdabter
                .Execute<DocumentArchive_Document_Number>("[Budget].Document_ArchiveInsert", request);
           

            return result;
        }
    }
}
 