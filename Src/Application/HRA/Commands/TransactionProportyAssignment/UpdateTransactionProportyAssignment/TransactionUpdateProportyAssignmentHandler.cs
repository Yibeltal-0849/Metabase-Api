using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.TransactionProportyAssignment.UpdateTransactionProportyAssignment
{
    public class TransactionUpdateProportyAssignmentHandler : IRequestHandler<TransactionupdateProportyAssignmentCommand, IList<proc_Transaction_Proporty_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public TransactionUpdateProportyAssignmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proc_Transaction_Proporty_AssignmentID>> Handle(TransactionupdateProportyAssignmentCommand request, CancellationToken cancellationToken)
        {
            Guid Trasn_Id = request.Trasn_Id;


            byte[] Documents = request.Documents;

            DateTime? Period = request.Period;
            DateTime? Created_Date = request.Created_Date;

            IList<proc_Transaction_Proporty_AssignmentID> result = await _procedureAdabter
                .Execute<proc_Transaction_Proporty_AssignmentID>("[dbo].[proc_Transaction_Proporty_AssignmentUpdate]",
                (nameof(Trasn_Id), Trasn_Id),
                (nameof(Documents), Documents),
                (nameof(Period), Period),
                (nameof(Created_Date), Created_Date));

            return result;
        }
    }
}
