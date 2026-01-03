



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblConsumption.proctblConsumptionInsert.proctblConsumptionInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumptionInsert stored procedure.


    public class proctblConsumptionInsertHandler : IRequestHandler<proctblConsumptionInsertCommand, IList<tblConsumption_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumption_id>> Handle( proctblConsumptionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumption_id> result = await _procedureAdabter
                .Execute<tblConsumption_id>("[ProprtyData].proc_tblConsumptionInsert", request);
           

            return result;
        }
    }
}
 