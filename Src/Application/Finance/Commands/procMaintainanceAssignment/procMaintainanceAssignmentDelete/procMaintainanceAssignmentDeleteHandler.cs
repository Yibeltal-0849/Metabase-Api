using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procMaintainanceAssignment.procMaintainanceAssignmentDelete.procMaintainanceAssignmentDeleteCommand
{

    /// @author  Shimels Alem  proc_Maintainance_AssignmentDelete stored procedure.


    public class procMaintainanceAssignmentDeleteHandler : IRequestHandler<procMaintainanceAssignmentDeleteCommand, IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMaintainanceAssignmentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainanceAssignment_Ment_AssignmentID>> Handle( procMaintainanceAssignmentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainanceAssignment_Ment_AssignmentID> result = await _procedureAdabter
                .Execute<MaintainanceAssignment_Ment_AssignmentID>("[FINA].proc_Maintainance_AssignmentDelete", request);
           

            return result;
        }
    }
}
  