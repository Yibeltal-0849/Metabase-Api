



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblDemand.proctblDemandInsert.proctblDemandInsertCommand
{

    /// @author  Shimels Alem  proc_tblDemandInsert stored procedure.


    public class proctblDemandInsertHandler : IRequestHandler<proctblDemandInsertCommand, IList<tblDemand_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDemandInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDemand_id>> Handle( proctblDemandInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblDemand_id> result = await _procedureAdabter
                .Execute<tblDemand_id>("[ProprtyData].proc_tblDemandInsert", request);
           

            return result;
        }
    }
}
 