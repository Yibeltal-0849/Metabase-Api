using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumptionTransaction.proctblConsumptionTransactionDelete.proctblConsumptionTransactionDeleteCommand
{

    /// @author  Shimels Alem  proc_tblConsumption_TransactionDelete stored procedure.


    public class proctblConsumptionTransactionDeleteHandler : IRequestHandler<proctblConsumptionTransactionDeleteCommand, IList<tblConsumptionTransaction_Tranaction_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumptionTransaction_Tranaction_Id>> Handle( proctblConsumptionTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumptionTransaction_Tranaction_Id> result = await _procedureAdabter
                .Execute<tblConsumptionTransaction_Tranaction_Id>("[ProprtyData].proc_tblConsumption_TransactionDelete", request);
           

            return result;
        }
    }
}
  