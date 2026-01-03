

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.JBankAccReconciliation.JBankAccReconciliationUpdate.JBankAccReconciliationUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationUpdate stored procedure.
	 
	 
      public class JBankAccReconciliationUpdateHandler : IRequestHandler<JBankAccReconciliationUpdateCommand, IList<JBankAccReconciliation_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JBankAccReconciliationUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JBankAccReconciliation_Branch_ID>> Handle( JBankAccReconciliationUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JBankAccReconciliation_Branch_ID> result = await _procedureAdabter
                .Execute<JBankAccReconciliation_Branch_ID>("[FINA].J_Bank_Acc_ReconciliationUpdate", request);
           

            return result;
        }
    }
}
 