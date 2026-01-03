

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblConsumer.proctblConsumerUpdate.proctblConsumerUpdateCommand
{

    /// @author  Shimels Alem  proc_tblConsumerUpdate stored procedure.


    public class proctblConsumerUpdateHandler : IRequestHandler<proctblConsumerUpdateCommand, IList<tblConsumer_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumer_id>> Handle( proctblConsumerUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumer_id> result = await _procedureAdabter
                .Execute<tblConsumer_id>("[ProprtyData].proc_tblConsumerUpdate", request);
           

            return result;
        }
    }
}
 