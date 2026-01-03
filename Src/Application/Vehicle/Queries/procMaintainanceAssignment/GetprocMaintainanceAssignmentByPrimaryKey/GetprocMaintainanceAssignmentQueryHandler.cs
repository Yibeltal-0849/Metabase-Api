using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentByPrimaryKey
{
    public class GetprocMaintainanceAssignmentQueryHandler : IRequestHandler<GetprocMaintainanceAssignmentByPrimaryKey, GetprocMaintainanceAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocMaintainanceAssignmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMaintainanceAssignmentLoadAllListVm> Handle(GetprocMaintainanceAssignmentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<MaintainanceAssignment> procMaintainanceAssignments = await _procedureAdabter
               .Execute<MaintainanceAssignment>("[Vehicle].[proc_Maintainance_AssignmentLoadByPrimaryKey]", request);
            GetprocMaintainanceAssignmentLoadAllListVm vm = new GetprocMaintainanceAssignmentLoadAllListVm
            {
                procMaintainanceAssignments = _mapper.Map<IList<MaintainanceAssignment>, IList<GetprocMaintainanceAssignmentLoadAllVm>>(procMaintainanceAssignments)
            };

            return vm;
        }
    }
}
