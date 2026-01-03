using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.DocumentArchive.DocumentArchiveUpdate.DocumentArchiveUpdateCommand
{ 

      public class DocumentArchiveUpdateHandler : IRequestHandler<DocumentArchiveUpdateCommand, IList<Document_Archive_Document_Number>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DocumentArchiveUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Document_Archive_Document_Number>> Handle( DocumentArchiveUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Document_Archive_Document_Number> result = await _procedureAdabter
                .Execute<Document_Archive_Document_Number>("[Budget].Document_ArchiveUpdate", request);
           

            return result;
        }
    }
}
 
