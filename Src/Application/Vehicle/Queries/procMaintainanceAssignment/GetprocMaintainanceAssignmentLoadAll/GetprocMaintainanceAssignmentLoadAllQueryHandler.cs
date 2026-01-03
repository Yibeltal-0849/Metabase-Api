using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentLoadAll
{
    class GetprocMaintainanceAssignmentLoadAllQueryHandler : IRequestHandler<GetprocMaintainanceAssignmentLoadAllQuery, GetprocMaintainanceAssignmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocMaintainanceAssignmentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMaintainanceAssignmentLoadAllListVm> Handle(GetprocMaintainanceAssignmentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<MaintainanceAssignment> procMaintainanceAssignments = await _procedureAdabter
               .Execute<MaintainanceAssignment>("[Vehicle].[proc_Maintainance_AssignmentLoadAll]");
            GetprocMaintainanceAssignmentLoadAllListVm vm = new GetprocMaintainanceAssignmentLoadAllListVm
            {
                procMaintainanceAssignments = _mapper.Map<IList<MaintainanceAssignment>, IList<GetprocMaintainanceAssignmentLoadAllVm>>(procMaintainanceAssignments)
            };

            return vm;
        }
    }
}
