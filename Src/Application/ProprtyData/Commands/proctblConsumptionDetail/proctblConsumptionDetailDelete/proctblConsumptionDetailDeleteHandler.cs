using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumptionDetail.proctblConsumptionDetailDelete.proctblConsumptionDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_tblConsumption_DetailDelete stored procedure.


    public class proctblConsumptionDetailDeleteHandler : IRequestHandler<proctblConsumptionDetailDeleteCommand, IList<tblConsumptionDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumptionDetail_id>> Handle( proctblConsumptionDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumptionDetail_id> result = await _procedureAdabter
                .Execute<tblConsumptionDetail_id>("[ProprtyData].proc_tblConsumption_DetailDelete", request);
           

            return result;
        }
    }
}
  