using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDemand.proctblDemandDelete.proctblDemandDeleteCommand
{

    /// @author  Shimels Alem  proc_tblDemandDelete stored procedure.


    public class proctblDemandDeleteHandler : IRequestHandler<proctblDemandDeleteCommand, IList<tblDemand_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDemandDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDemand_id>> Handle( proctblDemandDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblDemand_id> result = await _procedureAdabter
                .Execute<tblDemand_id>("[ProprtyData].proc_tblDemandDelete", request);
           

            return result;
        }
    }
}
  