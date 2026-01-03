using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceStatus.proctblResourceStatusDelete.proctblResourceStatusDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResource_StatusDelete stored procedure.


    public class proctblResourceStatusDeleteHandler : IRequestHandler<proctblResourceStatusDeleteCommand, IList<tblResourceStatus_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceStatusDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceStatus_id>> Handle( proctblResourceStatusDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceStatus_id> result = await _procedureAdabter
                .Execute<tblResourceStatus_id>("[ProprtyData].proc_tblResource_StatusDelete", request);
           

            return result;
        }
    }
}
  