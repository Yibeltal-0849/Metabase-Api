

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResourceDescriptions.proctblResourceDescriptionsUpdate.proctblResourceDescriptionsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblResourceDescriptionsUpdate stored procedure.


    public class proctblResourceDescriptionsUpdateHandler : IRequestHandler<proctblResourceDescriptionsUpdateCommand, IList<tblResourceDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceDescriptionsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceDescriptions_id>> Handle( proctblResourceDescriptionsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceDescriptions_id> result = await _procedureAdabter
                .Execute<tblResourceDescriptions_id>("[ProprtyData].proc_tblResourceDescriptionsUpdate", request);
           

            return result;
        }
    }
}
 