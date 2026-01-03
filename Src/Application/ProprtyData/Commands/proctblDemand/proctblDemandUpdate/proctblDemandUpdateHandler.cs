

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblDemand.proctblDemandUpdate.proctblDemandUpdateCommand
{

    /// @author  Shimels Alem  proc_tblDemandUpdate stored procedure.


    public class proctblDemandUpdateHandler : IRequestHandler<proctblDemandUpdateCommand, IList<tblDemand_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDemandUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDemand_id>> Handle( proctblDemandUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblDemand_id> result = await _procedureAdabter
                .Execute<tblDemand_id>("[ProprtyData].proc_tblDemandUpdate", request);
           

            return result;
        }
    }
}
 