using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procMaintainanceAssignment.GetprocMaintainanceAssignmentByPrimaryKey
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
               .Execute<MaintainanceAssignment>("[FINA].[proc_Maintainance_AssignmentLoadByPrimaryKey]", request);
            GetprocMaintainanceAssignmentLoadAllListVm vm = new GetprocMaintainanceAssignmentLoadAllListVm
            {
                procMaintainanceAssignments = _mapper.Map<IList<MaintainanceAssignment>, IList<GetprocMaintainanceAssignmentLoadAllVm>>(procMaintainanceAssignments)
            };

            return vm;
        }
    }
}
