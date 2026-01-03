using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceDescriptions.proctblResourceDescriptionsDelete.proctblResourceDescriptionsDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResourceDescriptionsDelete stored procedure.


    public class proctblResourceDescriptionsDeleteHandler : IRequestHandler<proctblResourceDescriptionsDeleteCommand, IList<tblResourceDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceDescriptionsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceDescriptions_id>> Handle( proctblResourceDescriptionsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceDescriptions_id> result = await _procedureAdabter
                .Execute<tblResourceDescriptions_id>("[ProprtyData].proc_tblResourceDescriptionsDelete", request);
           

            return result;
        }
    }
}
  