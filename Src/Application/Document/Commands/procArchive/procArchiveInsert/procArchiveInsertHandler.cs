



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;


namespace Application.Document.Commands.procArchive.procArchiveInsert.procArchiveInsertCommand
{

    /// @author  Shimels Alem  proc_ArchiveInsert stored procedure.


    public class procArchiveInsertHandler : IRequestHandler<procArchiveInsertCommand, IList<Archive_LetterID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procArchiveInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Archive_LetterID>> Handle( procArchiveInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Archive_LetterID> result = await _procedureAdabter
                .Execute<Archive_LetterID>("[Document ].[proc_ArchiveInsert]", request);
           

            return result;
        }
    }
}
 