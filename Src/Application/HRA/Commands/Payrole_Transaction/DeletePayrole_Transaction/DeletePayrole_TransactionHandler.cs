using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payrole_Transaction.DeletePayrole_Transaction
{
    public class DeletePayrole_TransactionHandler : IRequestHandler<DeletePayrole_TransactionCommand, IList<PayroleTransaction_Payrole_Trans_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeletePayrole_TransactionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayroleTransaction_Payrole_Trans_Id>> Handle(DeletePayrole_TransactionCommand request, CancellationToken cancellationToken)
        {
            Guid Payrole_Trans_Id = request.Payrole_Trans_Id;
            IList<PayroleTransaction_Payrole_Trans_Id> result = await _procedureAdabter
                .Execute<PayroleTransaction_Payrole_Trans_Id>("[HRA].[proc_Payrole_TransactionDelete]",
                (nameof(Payrole_Trans_Id), Payrole_Trans_Id));

            return result;
        }
    }
}
