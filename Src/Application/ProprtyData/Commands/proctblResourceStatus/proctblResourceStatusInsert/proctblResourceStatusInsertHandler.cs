



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceStatus.proctblResourceStatusInsert.proctblResourceStatusInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_StatusInsert stored procedure.


    public class proctblResourceStatusInsertHandler : IRequestHandler<proctblResourceStatusInsertCommand, IList<tblResourceStatus_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceStatusInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceStatus_id>> Handle( proctblResourceStatusInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceStatus_id> result = await _procedureAdabter
                .Execute<tblResourceStatus_id>("[ProprtyData].proc_tblResource_StatusInsert", request);
           

            return result;
        }
    }
}
 