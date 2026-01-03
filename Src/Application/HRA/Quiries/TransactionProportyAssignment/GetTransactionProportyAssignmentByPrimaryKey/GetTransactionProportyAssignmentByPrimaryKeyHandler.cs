using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.TransactionProportyAssignment.GetTransactionProportyAssignmentLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.TransactionProportyAssignment.GetTransactionProportyAssignmentByPrimaryKey
{
    public class GetTransactionProportyAssignmentByPrimaryKeyHandler : IRequestHandler<GetTransactionProportyAssignmentByPrimaryKey, GetTransactionProportyAssignmentListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetTransactionProportyAssignmentByPrimaryKeyHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetTransactionProportyAssignmentListVm> Handle(GetTransactionProportyAssignmentByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid Trasn_Id = request.Trasn_Id;
            IList<proc_Transaction_Proporty_Assignment> procPropertyAssignmnet = await _procedureAdabter
               .Execute<proc_Transaction_Proporty_Assignment>("[dbo].[proc_Transaction_Proporty_AssignmentLoadByPrimaryKey]", (nameof(Trasn_Id), Trasn_Id));
            GetTransactionProportyAssignmentListVm vm = new GetTransactionProportyAssignmentListVm
            {
                procPropertyAssignmnet = _mapper.Map<IList<proc_Transaction_Proporty_Assignment>, IList<GetTransactionProportyAssignmentLoadAllVm>>(procPropertyAssignmnet)
            };

            return vm;
        }
    }
}
