using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.TransactionProportyAssignment.GetTransactionProportyAssignmentLoadAll
{
    class GetTransactionProportyAssignmentQueryHandler : IRequestHandler<GetTransactionProportyAssignmentQuery, GetTransactionProportyAssignmentListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetTransactionProportyAssignmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTransactionProportyAssignmentListVm> Handle(GetTransactionProportyAssignmentQuery request, CancellationToken cancellationToken)
        {
            IList<proc_Transaction_Proporty_Assignment> procPropertyAssignmnet = await _procedureAdabter
               .Execute<proc_Transaction_Proporty_Assignment>("[dbo].[proc_Transaction_Proporty_AssignmentLoadAll]");
            GetTransactionProportyAssignmentListVm vm = new GetTransactionProportyAssignmentListVm
            {
                procPropertyAssignmnet = _mapper.Map<IList<proc_Transaction_Proporty_Assignment>, IList<GetTransactionProportyAssignmentLoadAllVm>>(procPropertyAssignmnet)
            };

            return vm;
        }
    }
}
