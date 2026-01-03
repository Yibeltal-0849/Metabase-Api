using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumer.proctblConsumerDelete.proctblConsumerDeleteCommand
{

    /// @author  Shimels Alem  proc_tblConsumerInsert stored procedure.


    public class proctblConsumerDeleteHandler : IRequestHandler<proctblConsumerDeleteCommand, IList<tblConsumer_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumer_id>> Handle( proctblConsumerDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumer_id> result = await _procedureAdabter
                .Execute<tblConsumer_id>("[ProprtyData].proc_tblConsumerDelete", request);
           

            return result;
        }
    }
}
  