

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;



namespace Application.Document.Commands.procArchive.procArchiveUpdate.procArchiveUpdateCommand
{

    /// @author  Shimels Alem  proc_ArchiveUpdate stored procedure.


    public class procArchiveUpdateHandler : IRequestHandler<procArchiveUpdateCommand, IList<Archive_LetterID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procArchiveUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Archive_LetterID>> Handle( procArchiveUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Archive_LetterID> result = await _procedureAdabter
                .Execute<Archive_LetterID>("[Document ].proc_ArchiveUpdate", request);
           

            return result;
        }
    }
}
 