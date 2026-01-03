using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payrole_Transaction.UpdatePayrole_Transaction
{
    public class UpdatePayrole_TransactionHandler : IRequestHandler<UpdatePayrole_TransactionCommand, IList<PayroleTransaction_Payrole_Trans_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdatePayrole_TransactionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayroleTransaction_Payrole_Trans_Id>> Handle(UpdatePayrole_TransactionCommand request, CancellationToken cancellationToken)
        {

            IList<PayroleTransaction_Payrole_Trans_Id> result = await _procedureAdabter
                .Execute<PayroleTransaction_Payrole_Trans_Id>("[HRA].[proc_Payrole_TransactionUpdate]", request);

            return result;
        }
    }
}
