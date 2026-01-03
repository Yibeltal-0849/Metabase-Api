

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblConsumptionTransaction.proctblConsumptionTransactionUpdate.proctblConsumptionTransactionUpdateCommand
{

    /// @author  Shimels Alem  proc_tblConsumption_TransactionUpdate stored procedure.


    public class proctblConsumptionTransactionUpdateHandler : IRequestHandler<proctblConsumptionTransactionUpdateCommand, IList<tblConsumptionTransaction_Tranaction_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblConsumptionTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblConsumptionTransaction_Tranaction_Id>> Handle( proctblConsumptionTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblConsumptionTransaction_Tranaction_Id> result = await _procedureAdabter
                .Execute<tblConsumptionTransaction_Tranaction_Id>("[ProprtyData].proc_tblConsumption_TransactionUpdate", request);
           

            return result;
        }
    }
}
 