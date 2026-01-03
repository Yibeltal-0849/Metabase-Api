

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResource.proctblResourceUpdate.proctblResourceUpdateCommand
{

    /// @author  Shimels Alem  proc_tblResourceUpdate stored procedure.


    public class proctblResourceUpdateHandler : IRequestHandler<proctblResourceUpdateCommand, IList<tblResource_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResource_id>> Handle( proctblResourceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResource_id> result = await _procedureAdabter
                .Execute<tblResource_id>("[ProprtyData].proc_tblResourceUpdate", request);
           

            return result;
        }
    }
}
 