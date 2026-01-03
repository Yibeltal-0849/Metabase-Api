using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.TransactionProportyAssignment.DeleteTransactionProportyAssignment
{
    public class DeleteTransactionProportyAssignmentHandler : IRequestHandler<DeleteTransactionProportyAssignmentCommand, IList<proc_Transaction_Proporty_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteTransactionProportyAssignmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proc_Transaction_Proporty_AssignmentID>> Handle(DeleteTransactionProportyAssignmentCommand request, CancellationToken cancellationToken)
        {
            Guid Trasn_Id = request.Trasn_Id;
            IList<proc_Transaction_Proporty_AssignmentID> result = await _procedureAdabter
                .Execute<proc_Transaction_Proporty_AssignmentID>("[dbo].[proc_Transaction_Proporty_AssignmentDelete]",
                (nameof(Trasn_Id), Trasn_Id));

            return result;
        }
    }
}
