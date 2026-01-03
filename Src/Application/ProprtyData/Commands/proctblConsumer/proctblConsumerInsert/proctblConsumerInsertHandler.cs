



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblConsumer.proctblConsumerInsert.proctblConsumerInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumerInsert stored procedure.


    public class proctblConsumerInsertHandler : IRequestHandler<proctblConsumerInsertCommand, IList<tblConsumer_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumerInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumer_id>> Handle( proctblConsumerInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumer_id> result = await _procedureAdabter
                .Execute<tblConsumer_id>("[ProprtyData].proc_tblConsumerInsert", request);
           

            return result;
        }
    }
}
 