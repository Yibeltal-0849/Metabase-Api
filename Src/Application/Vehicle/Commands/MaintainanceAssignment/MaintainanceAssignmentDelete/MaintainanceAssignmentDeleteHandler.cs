using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.MaintainanceAssignment.MaintainanceAssignmentDelete.MaintainanceAssignmentDeleteCommand
{ 	 
	 
      public class MaintainanceAssignmentDeleteHandler : IRequestHandler<MaintainanceAssignmentDeleteCommand, IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public MaintainanceAssignmentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainanceAssignment_Ment_AssignmentID>> Handle( MaintainanceAssignmentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainanceAssignment_Ment_AssignmentID> result = await _procedureAdabter
                .Execute<MaintainanceAssignment_Ment_AssignmentID>("[FixedAsset].Maintainance_AssignmentDelete", request);
           

            return result;
        }
    }
}
 
