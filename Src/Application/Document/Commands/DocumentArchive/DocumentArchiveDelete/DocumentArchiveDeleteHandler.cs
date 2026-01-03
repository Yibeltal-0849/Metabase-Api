using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Commands.DocumentArchive.DocumentArchiveDelete.DocumentArchiveDeleteCommand
{

    /// @author  Shimels Alem  Document_ArchiveDelete stored procedure.


    public class DocumentArchiveDeleteHandler : IRequestHandler<DocumentArchiveDeleteCommand , IList<DocumentArchive_Document_Number>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DocumentArchiveDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DocumentArchive_Document_Number>> Handle( DocumentArchiveDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<DocumentArchive_Document_Number> result = await _procedureAdabter
                .Execute<DocumentArchive_Document_Number>("[Budget].Document_ArchiveDelete", request);
           

            return result;
        }
    }
}
  