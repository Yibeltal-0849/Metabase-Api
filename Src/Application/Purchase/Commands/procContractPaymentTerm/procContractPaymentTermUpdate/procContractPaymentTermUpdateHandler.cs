

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;



namespace Application.Purchase.Commands.procContractPaymentTerm.procContractPaymentTermUpdate.procContractPaymentTermUpdateCommand
{

    /// @author  Shimels Alem  proc_Contract_PaymentTermUpdate stored procedure.


    public class procContractPaymentTermUpdateHandler : IRequestHandler<procContractPaymentTermUpdateCommand, IList<ContractPaymentTerm_PaymentTermID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procContractPaymentTermUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ContractPaymentTerm_PaymentTermID>> Handle( procContractPaymentTermUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ContractPaymentTerm_PaymentTermID> result = await _procedureAdabter
                .Execute<ContractPaymentTerm_PaymentTermID>("[Purchase].proc_Contract_PaymentTermUpdate", request);
           

            return result;
        }
    }
}
 