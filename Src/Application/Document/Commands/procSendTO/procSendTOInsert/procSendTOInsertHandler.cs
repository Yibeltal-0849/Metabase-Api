



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;


namespace Application.Document.Commands.procSendTO.procSendTOInsert.procSendTOInsertCommand
{

    /// @author  Shimels Alem  proc_Send_TOInsert stored procedure.


    public class procSendTOInsertHandler : IRequestHandler<procSendTOInsertCommand, IList<SendTO_EmailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSendTOInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SendTO_EmailID>> Handle( procSendTOInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SendTO_EmailID> result = await _procedureAdabter
                .Execute<SendTO_EmailID>("[Document].proc_Send_TOInsert", request);


            return result;
        }
    }
}
 