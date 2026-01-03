

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.MaintainanceAssignment.MaintainanceAssignmentUpdate.MaintainanceAssignmentUpdateCommand
{

    /// @author  Shimels Alem  Maintainance_AssignmentUpdate stored procedure.


    public class MaintainanceAssignmentUpdateHandler : IRequestHandler<MaintainanceAssignmentUpdateCommand, IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public MaintainanceAssignmentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainanceAssignment_Ment_AssignmentID>> Handle( MaintainanceAssignmentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainanceAssignment_Ment_AssignmentID> result = await _procedureAdabter
                .Execute<MaintainanceAssignment_Ment_AssignmentID>("[FixedAsset].Maintainance_AssignmentUpdate", request);
           

            return result;
        }
    }
}
 