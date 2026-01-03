using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procSendTO.procSendTODelete.procSendTODeleteCommand
{

    /// @author  Shimels Alem  proc_Send_TODelete stored procedure.


    public class procSendTODeleteHandler : IRequestHandler<procSendTODeleteCommand, IList<SendTO_EmailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSendTODeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SendTO_EmailID>> Handle( procSendTODeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SendTO_EmailID> result = await _procedureAdabter
                .Execute<SendTO_EmailID>("[Document].proc_Send_TODelete", request);
           

            return result;
        }
    }
}
  