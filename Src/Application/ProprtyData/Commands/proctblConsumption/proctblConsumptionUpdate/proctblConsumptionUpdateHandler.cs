

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblConsumption.proctblConsumptionUpdate.proctblConsumptionUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXXX stored procedure.
	 
	 
      public class proctblConsumptionUpdateHandler : IRequestHandler<proctblConsumptionUpdateCommand, IList<tblConsumption_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumption_id>> Handle( proctblConsumptionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumption_id> result = await _procedureAdabter
                .Execute<tblConsumption_id>("[ProprtyData].proc_tblConsumptionUpdate", request);
           

            return result;
        }
    }
}
 