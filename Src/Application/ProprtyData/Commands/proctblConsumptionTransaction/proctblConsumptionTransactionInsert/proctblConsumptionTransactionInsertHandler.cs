



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblConsumptionTransaction.proctblConsumptionTransactionInsert.proctblConsumptionTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumption_TransactionInsert stored procedure.


    public class proctblConsumptionTransactionInsertHandler : IRequestHandler<proctblConsumptionTransactionInsertCommand, IList<tblConsumptionTransaction_Tranaction_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionTransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumptionTransaction_Tranaction_Id>> Handle( proctblConsumptionTransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumptionTransaction_Tranaction_Id> result = await _procedureAdabter
                .Execute<tblConsumptionTransaction_Tranaction_Id>("[ProprtyData].proc_tblConsumption_TransactionInsert", request);
           

            return result;
        }
    }
}
 