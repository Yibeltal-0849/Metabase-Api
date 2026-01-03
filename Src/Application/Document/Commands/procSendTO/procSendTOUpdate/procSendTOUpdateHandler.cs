

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procSendTO.procSendTOUpdate.procSendTOUpdateCommand
{

    /// @author  Shimels Alem  proc_Send_TOUpdate stored procedure.


    public class procSendTOUpdateHandler : IRequestHandler<procSendTOUpdateCommand, IList<SendTO_EmailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSendTOUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SendTO_EmailID>> Handle( procSendTOUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SendTO_EmailID> result = await _procedureAdabter
                .Execute<SendTO_EmailID>("[Document].proc_Send_TOUpdate", request);
           

            return result;
        }
    }
}
 