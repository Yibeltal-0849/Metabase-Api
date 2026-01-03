



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procMaintainanceAssignment.procMaintainanceAssignmentInsert.procMaintainanceAssignmentInsertCommand
{

    /// @author  Shimels Alem  proc_Maintainance_AssignmentInsert stored procedure.


    public class procMaintainanceAssignmentInsertHandler : IRequestHandler<procMaintainanceAssignmentInsertCommand, IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMaintainanceAssignmentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainanceAssignment_Ment_AssignmentID>> Handle( procMaintainanceAssignmentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainanceAssignment_Ment_AssignmentID> result = await _procedureAdabter
                .Execute<MaintainanceAssignment_Ment_AssignmentID>("[FINA].proc_Maintainance_AssignmentInsert", request);
           

            return result;
        }
    }
}
 