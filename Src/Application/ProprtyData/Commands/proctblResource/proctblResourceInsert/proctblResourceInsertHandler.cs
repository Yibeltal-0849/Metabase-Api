



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResource.proctblResourceInsert.proctblResourceInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceInsert stored procedure.


    public class proctblResourceInsertHandler : IRequestHandler<proctblResourceInsertCommand, IList<tblResource_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResource_id>> Handle( proctblResourceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResource_id> result = await _procedureAdabter
                .Execute<tblResource_id>("[ProprtyData].proc_tblResourceInsert", request);
           

            return result;
        }
    }
}
 