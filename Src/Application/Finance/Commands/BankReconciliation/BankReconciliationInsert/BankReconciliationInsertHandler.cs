



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.BankReconciliation.BankReconciliationInsert.BankReconciliationInsertCommand
{

    /// @author  Shimels Alem  C_Bank_DepositInsert stored procedure.


    public class BankReconciliationInsertHandler : IRequestHandler<BankReconciliationInsertCommand, IList<BankReconciliation_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BankReconciliationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BankReconciliation_Id>> Handle( BankReconciliationInsertCommand request, CancellationToken cancellationToken)
        {

            IList<BankReconciliation_Id> result = await _procedureAdabter
                .Execute<BankReconciliation_Id>("[dbo].proc_Bank_reconciliationInsert", request);
           

            return result;
        }
    }
}
 