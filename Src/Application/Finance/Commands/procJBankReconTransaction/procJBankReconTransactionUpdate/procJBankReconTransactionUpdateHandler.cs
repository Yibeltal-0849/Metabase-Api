

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procJBankReconTransaction.procJBankReconTransactionUpdate.procJBankReconTransactionUpdateCommand
{ 
	 
	/// @author  Shimels Alem  proc_J_Bank_Recon_TransactionUpdate stored procedure.
	 
	 
      public class procJBankReconTransactionUpdateHandler : IRequestHandler<procJBankReconTransactionUpdateCommand, IList<JBankReconTransaction_TransID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJBankReconTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JBankReconTransaction_TransID>> Handle( procJBankReconTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JBankReconTransaction_TransID> result = await _procedureAdabter
                .Execute<JBankReconTransaction_TransID>("[FINA].proc_J_Bank_Recon_TransactionUpdate", request);
           

            return result;
        }
    }
}
 