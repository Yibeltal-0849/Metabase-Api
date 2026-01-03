using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumption.proctblConsumptionDelete.proctblConsumptionDeleteCommand
{

    /// @author  Shimels Alem  proc_tblConsumptionDelete stored procedure.


    public class proctblConsumptionDeleteHandler : IRequestHandler<proctblConsumptionDeleteCommand, IList<tblConsumption_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumption_id>> Handle( proctblConsumptionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumption_id> result = await _procedureAdabter
                .Execute<tblConsumption_id>("[ProprtyData].proc_tblConsumptionDelete", request);
           

            return result;
        }
    }
}
  